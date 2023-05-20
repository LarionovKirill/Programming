using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using OOP.Model.Orders;
using OOP.Model.Enums;

namespace OOP.View.Tabs
{
    /// <summary>
    /// Класс элемента приоритетного заказа.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Свойство приоритетного заказа.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private PriorityOrder PriorityOrder { get; set; }

        /// <summary>
        /// Словарь, хранящий перечисление и их значение.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Dictionary<Model.DeliveryTime, string> TimeDelivery { get; set; }


        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Model.Item> Items = new List<Model.Item>();

        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод заполняет поля формы.
        /// </summary>
        private void FillFields()
        {
            PriorityOrder = Services.OrderGenerator.GeneratePriorityOrder();
            addressControl1.FillAddress(PriorityOrder.Address);
            idTextBox.Text = PriorityOrder.Id.ToString();
            createdTextBox.Text = PriorityOrder.DateOfCreate.ToString();
        }

        /// <summary>
        /// Метод выполняется при запуске формы.
        /// </summary>
        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            FillFields();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var item in statuses)
            {
                statusComboBox.Items.Add(item);
            }
            TimeDelivery = Services.EnumGetter.GetDeliveryTime();

            foreach (var item in TimeDelivery)
            {
                deliveryTimeComboBox.Items.Add(item.Value);
            }
        }

        /// <summary>
        /// Метод добавляет случайный товар в товары заказа.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var randomItem = Items[random.Next(0, Items.Count)];
            itemsListBox.Items.Add(randomItem.Name);
            PriorityOrder.Items.Add(randomItem);
            costLabel.Text = PriorityOrder.FullCost.ToString();
        }

        /// <summary>
        /// Удаляет товар из корзины.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                var index = itemsListBox.SelectedIndex;
                PriorityOrder.Items.RemoveAt(index);
                itemsListBox.Items.RemoveAt(index);
                costLabel.Text = PriorityOrder.FullCost.ToString();
            }
            else 
            {
                MessageBox.Show("Выберите товар из списка.");
            }
        }

        /// <summary>
        /// Метод очищает корзину.
        /// </summary>
        private void ClearOrderIutton_Click(object sender, EventArgs e)
        {
            itemsListBox.Items.Clear();
            costLabel.Text = PriorityOrder.FullCost.ToString();
            FillFields();
        }
    }
}
