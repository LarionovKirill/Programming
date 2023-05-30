using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OOP.Model;
using OOP.Model.Enums;
using OOP.Services;

namespace OOP.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Свойство поля _items.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Флаг режима изменения.
        /// </summary>
        private bool ChangeMode { get; set; } = false;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool AddMode { get; set; } = false;

        /// <summary>
        /// Копия товара.
        /// </summary>
        private Item CopyItem { get; set; } = new Item();

        /// <summary>
        /// Свойство товаров, отображаемых в ListBox.
        /// </summary>
        List<Item> DisplayedItems { get; set; } = new List<Item>();

        /// <summary>
        /// Метод создающий компоненты формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            DisplayedItems = Items;
        }

        /// <summary>
        /// Метод добавляет товар в список.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //Разблокировка полей для ввода.
            AddMode = true;
            ClearFields();
            itemListBox.SelectedIndex = -1;
            OpenFields();
        }

        /// <summary>
        /// Обновляет информацию при запуске приложения.
        /// </summary>
        public void UpdateInformation(List<Item> listItems)
        {
            if (listItems != null)
            {
                foreach (var items in listItems)
                {
                    itemListBox.Items.Add(items.Name);
                }
            }
        }


        /// <summary>
        /// Удаляет товар из списка.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                Items.RemoveAt(index);
                itemListBox.Items.RemoveAt(index);
                itemListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Проверяет изменения поля цены.
        /// </summary>
        private void СostItemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (costItemTextBox.Text == string.Empty)
            {
                costItemTextBox.BackColor = Color.White;
                return;
            }
            try
            {
                CopyItem.Cost = decimal.Parse(costItemTextBox.Text);
                costItemTextBox.BackColor = Color.White;
            }
            catch
            {
                costItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверяет изменения поля имени.
        /// </summary>
        private void NameItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CopyItem.Name = nameItemTextBox.Text;
                nameItemTextBox.BackColor = Color.White;
            }
            catch
            {
                nameItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверяет изменения поля описания.
        /// </summary>
        private void DescriptionItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CopyItem.Info = descriptionItemTextBox.Text;
                descriptionItemTextBox.BackColor = Color.White;
            }
            catch
            {
                descriptionItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Срабатывает при выборе товара из списка.
        /// </summary>
        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                FillingInTheProductField(Items[index]);
                if (ChangeMode == true)
                {
                    CloseFields();
                }
            }
        }

        /// <summary>
        /// Заполняет поля из значений класса.
        /// </summary>
        private void FillingInTheProductField(Model.Item current)
        {
            idItemTextBox.Text = current.Id.ToString();
            nameItemTextBox.Text = current.Name;
            descriptionItemTextBox.Text = current.Info;
            costItemTextBox.Text = current.Cost.ToString();
            categoryComboBox.SelectedItem = current.ItemCategory;
        }

        /// <summary>
        /// Метод выполняется при запуске формы. Он заполняет comboBox.
        /// </summary>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            var contents = Enum.GetValues(typeof(ItemCategory));
            foreach (var items in contents)
            {
                categoryComboBox.Items.Add(items);
            }
            categoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод сохранет изменение категории выбранного товара.
        /// </summary>
        private void СategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                Items[index].ItemCategory = (ItemCategory)Enum.Parse(typeof(ItemCategory),
                    categoryComboBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Дает возможность изменить данные.
        /// </summary>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                ChangeMode = true;
                var index = itemListBox.SelectedIndex;
                OpenFields();
                ToCopyItem(Items[index]);
                findingTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Выберите товар.");
            }
        }

        /// <summary>
        /// Открывает поля.
        /// </summary>
        private void OpenFields()
        {
            categoryComboBox.Enabled = true;
            saveButton.Visible = true;
            cancelButton.Visible = true;
            descriptionItemTextBox.ReadOnly = false;
            nameItemTextBox.ReadOnly = false;
            costItemTextBox.ReadOnly = false;
        }

        /// <summary>
        /// Закрывает поля.
        /// </summary>
        private void CloseFields()
        {
            categoryComboBox.Enabled = false;
            saveButton.Visible = false;
            cancelButton.Visible = false;
            descriptionItemTextBox.ReadOnly = true;
            nameItemTextBox.ReadOnly = true;
            costItemTextBox.ReadOnly = true;
            ChangeMode = false;
            AddMode = false;
        }

        /// <summary>
        /// Метод копии класса товара.
        /// </summary>
        /// <param name="item"></param>
        private void ToCopyItem(Model.Item item)
        {
            item.CopyInformation(CopyItem);
        }

        /// <summary>
        /// Кнопка сохраняет изменения.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AddMode)
            {
                try
                {
                    //Получение данных с формы.
                    var name = nameItemTextBox.Text;
                    var description = descriptionItemTextBox.Text;
                    var cost = decimal.Parse(costItemTextBox.Text);
                    var category = (ItemCategory)Enum.Parse(typeof(ItemCategory),
                        categoryComboBox.SelectedItem.ToString());

                    //Добавление объекта в список.
                    Items.Add(new Model.Item(
                        name,
                        description,
                        cost,
                        category));
                    itemListBox.Items.Add(Items.Last().Name);

                }
                catch
                {
                    MessageBox.Show("Введите верные значения.");
                }
            }
            else if (ChangeMode)
            {
                var index = itemListBox.SelectedIndex;
                if (costItemTextBox.BackColor == Color.White &&
                    nameItemTextBox.BackColor == Color.White &&
                    descriptionItemTextBox.BackColor == Color.White)
                {
                    CopyItem.CopyInformation(Items[index]);
                    itemListBox.Items.Insert(index, Items[index].Name);
                    itemListBox.Items.RemoveAt(index + 1);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                else
                {
                    MessageBox.Show("Мы не можем сохранить такие данные.");
                }
                itemListBox.SelectedIndex = -1;
            }
            ClearFields();
            CloseFields();
        }

        /// <summary>
        /// Кнопка отменяет изменения.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (ChangeMode)
            {
                MessageBox.Show("Изменения не были сохранены");
                itemListBox.SelectedIndex = -1;
            }
            ClearFields();
            CloseFields();
        }

        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearFields()
        {
            nameItemTextBox.Text = string.Empty;
            costItemTextBox.Text = string.Empty;
            descriptionItemTextBox.Text = string.Empty;
            idItemTextBox.Text = string.Empty;
            categoryComboBox.SelectedItem = string.Empty;
        }

        /// <summary>
        /// Метод оставляет товары c вписанной подстрокой.
        /// </summary>
        private void FindingTextBox_TextChanged(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
            if (findingTextBox.Text == string.Empty)
            {
                UpdateInformation(Items);
            }
            else
            {
                CompareValues comparing  = DataTools.FindItemName;
                DisplayedItems =  DataTools.FilteringItem(Items, findingTextBox.Text, comparing);
                UpdateInformation(DisplayedItems);
            }
        }
    }
}
