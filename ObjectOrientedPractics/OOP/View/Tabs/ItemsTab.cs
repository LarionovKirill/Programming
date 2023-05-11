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
    /// <summary>
    /// Пользовательский интерфейс пользовательского окна.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Model.Item> _items;

        /// <summary>
        /// Свойство поля _items.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Item> Items
        {
            get
            {
                return _items;
            }
            set 
            {
                _items = value;
            }
        }
           
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
                var category = (Model.ItemCategory)Enum.Parse(typeof(Model.ItemCategory),
                    categoryComboBox.SelectedItem.ToString());
                var cost = decimal.Parse(costItemTextBox.Text);
               
                //Добавление объекта в список.
                Items.Add(new Model.Item(
                    name,
                    description,
                    cost));
                itemListBox.Items.Add($"Товар : {Items.Last().Id}");
            }
            catch
            {
                MessageBox.Show("Введите верные значения.");
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
                if (itemListBox.SelectedIndex >= 0)
                {
                    var index = itemListBox.SelectedIndex;
                    Items[index].Cost = decimal.Parse(costItemTextBox.Text);
                }
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
                if (itemListBox.SelectedIndex >= 0)
                {
                    var index = itemListBox.SelectedIndex;
                    Items[index].Name = nameItemTextBox.Text;
                }
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
                if (itemListBox.SelectedIndex >= 0)
                {
                    var index = itemListBox.SelectedIndex;
                    Items[index].Info = descriptionItemTextBox.Text;
                }
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
    }
}
