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
    /// <summary>
    /// Класс интерфейса товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Стандартный делегат Func для сортировки списка товаров.
        /// </summary>
        Func<Item, Item, bool> sort;

        /// <summary>
        /// Делегат изменения товара.
        /// </summary>
        public delegate void ChangeItem();

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
        private List<Item> DisplayedItems { get; set; } = new List<Item>();

        /// <summary>
        /// Свойство словаря сортировок.
        /// </summary>
        private Dictionary<string, Func<Item, Item, bool>> SortingName { get; set; } 
            = new Dictionary<string, Func<Item, Item, bool>>();

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
            findingTextBox.Text = string.Empty;
            ItemsChanged?.Invoke();
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

                    items.NameChanged += SetItemName;
                    items.CostChanged += SetItemCost;
                    items.InfoChanged += SetItemDescription;
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

                Items[index].InfoChanged -= SetItemDescription;
                Items[index].NameChanged -= SetItemName;
                Items[index].CostChanged -= SetItemCost;

                Items.RemoveAt(index);
                itemListBox.Items.RemoveAt(index);

                itemListBox.SelectedIndex = 0;
                DisplayedItems = Items;

                ItemsChanged?.Invoke();
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
        /// Метод заполняет поле стоимости при помощи события.
        /// </summary>
        private void SetItemCost(object sender, EventArgs e)
        {
           if (sender is Item)
			{
                var item = (Item)sender;
                costItemTextBox.Text = item.Cost.ToString();
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
        /// Метод заполняет поле названия при помощи события.
        /// </summary>
        private void SetItemName(object sender, EventArgs e)
        {
            if (sender is Item)
            {
                var item = (Item)sender;
                nameItemTextBox.Text = item.Name.ToString();
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
        /// Метод заполняет поле названия при помощи события.
        /// </summary>
        private void SetItemDescription (object sender, EventArgs e)
        {
            if (sender is Item)
            {
                var item = (Item)sender;
                descriptionItemTextBox.Text = item.Info.ToString();
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
                FillingInTheProductField(DisplayedItems[index]);
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
            //Передача данных.
            DisplayedItems = Items;

            var contents = Enum.GetValues(typeof(ItemCategory));
            foreach (var items in contents)
            {
                categoryComboBox.Items.Add(items);
            }
            categoryComboBox.SelectedIndex = 0;

            //Заполнение списка сортировок товаров.
            SortingName = new Dictionary<string, Func<Item, Item, bool>>
                {
                    ["Name"] = Services.DataTools.CompareName,
                    ["Cost(Ascending)"] = Services.DataTools.CompareAscending,
                    ["Cost(descending)"] = Services.DataTools.CompareDescending,
                };

            foreach (var sort in SortingName)
            {
                sortingComboBox.Items.Add(sort.Key);
            }

            sortingComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод сохранет изменение категории выбранного товара.
        /// </summary>
        private void СategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                DisplayedItems[index].ItemCategory = (ItemCategory)Enum.Parse(typeof(ItemCategory),
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
                ToCopyItem(DisplayedItems[index]);
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
                    DisplayedItems = Items;
                    ItemsChanged?.Invoke();
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
                    itemListBox.Items.Insert(index, DisplayedItems[index].Name);
                    itemListBox.Items.RemoveAt(index + 1);
                    MessageBox.Show("Данные успешно сохранены.");
                    ItemsChanged?.Invoke();
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
            findingTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Метод оставляет товары c вписанной подстрокой.
        /// </summary>
        private void FindingTextBox_TextChanged(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
            DisplayedItems = Items;
            if (findingTextBox.Text == string.Empty)
            {
                UpdateInformation(Items);
            }
            else
            {
                Func<Item, object, bool> comparing  = DataTools.FindItemName;
                DisplayedItems =  DataTools.FilteringItem(Items, findingTextBox.Text, comparing);
                UpdateInformation(DisplayedItems);
            }
        }

        /// <summary>
        /// Метод сортирует товары по выбранным категориям.
        /// </summary>
        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var typeOfSort = sortingComboBox.SelectedItem.ToString();
            sort = SortingName[typeOfSort];
            CallSort(sort);
        }

        /// <summary>
        /// Метод вызывает сортировку по выбранному типу.
        /// </summary>
        /// <param name="dict">Словарь с сортировками и методами.</param>
        /// <param name="key">Ключ словаря.</param>
        private void CallSort(Func<Item, Item, bool> sort)
        {
            itemListBox.Items.Clear();
            //sort = dict[key];
            DisplayedItems = DataTools.SortItems(DisplayedItems, sort);
            UpdateInformation(DisplayedItems);
        }

        /// <summary>
        /// Свобытие изменения товара.
        /// </summary>
        public event ChangeItem ItemsChanged;
    }
}
