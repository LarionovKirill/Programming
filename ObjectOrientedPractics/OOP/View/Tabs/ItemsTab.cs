using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Свойство поля _items.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Item> Items { get; set; }

        /// <summary>
        /// Флаг режима изменения.
        /// </summary>
        private bool _changeMode { get; set; } = false;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool _addMode { get; set; } = false;

        /// <summary>
        /// Копия товара.
        /// </summary>
        private Model.Item _copyItem { get; set; } = new Model.Item();
            
        /// <summary>
        /// Метод создающий компоненты формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод добавляет товар в список.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Получение данных с формы.
                var name = nameItemTextBox.Text;
                var description = descriptionItemTextBox.Text;
                var cost = decimal .Parse(costItemTextBox.Text);
                var category = (Model.ItemCategory)Enum.Parse(typeof(Model.ItemCategory),
                    categoryComboBox.SelectedItem.ToString());
               
                //Добавление объекта в список.
                Items.Add(new Model.Item(
                    name,
                    description,
                    cost,
                    category));
                itemListBox.Items.Add($"Товар : {Items.Last().Id}");
            }
            catch
            {
                MessageBox.Show("Введите верные значения.");
            }
            //Блокировка полей для ввода.
            _addMode = true;
            ClearFields();
            itemListBox.SelectedIndex = -1;
            OpenFields();
        }

        /// <summary>
        /// Обновляет информацию при запуске приложения.
        /// </summary>
        public void UpdateInformation()
        {
            if (Items != null)
            {
                foreach (var items in Items)
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
                _copyItem.Cost = decimal.Parse(costItemTextBox.Text);
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
                _copyItem.Name = nameItemTextBox.Text;
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
                _copyItem.Info = descriptionItemTextBox.Text;
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
                if (_changeMode == true)
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
            var contents = Enum.GetValues(typeof(Model.ItemCategory));
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
                Items[index].ItemCategory = (Model.ItemCategory)Enum.Parse(typeof(Model.ItemCategory),
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
                _changeMode = true;
                var index = itemListBox.SelectedIndex;
                OpenFields();
                ToCopyItem(Items[index]);
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
            _changeMode = false;
            _addMode = false;
        }

        /// <summary>
        /// Метод копии класса товара.
        /// </summary>
        /// <param name="item"></param>
        private void ToCopyItem(Model.Item item)
        {
            item.CopyInformation(_copyItem);
        }

        /// <summary>
        /// Кнопка сохраняет изменения.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_addMode)
            {
                try
                {
                    //Получение данных с формы.
                    var name = nameItemTextBox.Text;
                    var description = descriptionItemTextBox.Text;
                    var cost = decimal.Parse(costItemTextBox.Text);
                    var category = (Model.ItemCategory)Enum.Parse(typeof(Model.ItemCategory),
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
            else if (_changeMode)
            {
                var index = itemListBox.SelectedIndex;
                if (costItemTextBox.BackColor == Color.White &&
                    nameItemTextBox.BackColor == Color.White &&
                    descriptionItemTextBox.BackColor == Color.White)
                {
                    _copyItem.CopyInformation(Items[index]);
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
            if (_changeMode)
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
    }
}
