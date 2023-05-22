using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using OOP.Model.Orders;
using OOP.Model.Enums;

namespace OOP.View.Tabs
{
    /// <summary>
    /// Форма заказов.
    /// </summary>
    public partial class ordersTab : UserControl
    {
        /// <summary>
        /// Свойство для списка пользователй.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers { get; set; }

        /// <summary>
        /// Свойство для списка заказов.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Order> Orders { get; set; } = new List<Order>();

        public ordersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Форматирует информацию из класса Address в необходимую строку.
        /// </summary>
        /// <param name="address"></param>
        /// <returns>Выходная строка.</returns>
        private string GetFormatAddress(Model.Address address)
        {
            return $"{address.Index}, {address.Country}, {address.City}, st:{address.Street}," +
                $"{address.Building}, ap.{address.Apartment}";
        }

        /// <summary>
        /// Метод обновляет информацию о заказах.
        /// </summary>
        public void UpdateInformation()
        {
            informationTable.Rows.Clear();
            if (Orders != null)
            {
                Orders.Clear();
            }
            foreach (var customer in Customers)
            {
                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    informationTable.Rows.Add(
                        order.Id,
                        order.DateOfCreate.ToString("dd.MM.yyyy"),
                        customer.FullName,
                        GetFormatAddress(order.Address),
                        order.FullCost,
                        order.OrderStatus);
                }
            }
        }

        /// <summary>
        /// Заполянет поля обычного заказа.
        /// </summary>
        private void FillBasicOrder(Order order)
        {
            idTextBox.Text = order.Id.ToString();
            creationTextBox.Text = order.DateOfCreate.ToString("dd.MM.yyyy");
            statusComboBox.SelectedItem = order.OrderStatus;
            var currentAddress = order.Address;
            addressControl.FillAddress(currentAddress);

            foreach (var items in order.Items)
            {
                ordersItemsListBox.Items.Add(items.Name);
            }

            costLabel.Text = order.FullCost.ToString();
        }


        /// <summary>
        /// Заполянет поля обычного заказа.
        /// </summary>
        private void FillPriorityOrder(PriorityOrder order)
        {
            idTextBox.Text = order.Id.ToString();
            creationTextBox.Text = order.DateOfCreate.ToString("dd.MM.yyyy");
            statusComboBox.SelectedItem = order.OrderStatus;
            var currentAddress = order.Address;
            addressControl.FillAddress(currentAddress);

            foreach (var items in order.Items)
            {
                ordersItemsListBox.Items.Add(items.Name);
            }

            costLabel.Text = order.FullCost.ToString();
            var dict = Services.EnumGetter.GetDeliveryTime();
            deliveryTimeComboBox.SelectedItem = dict[order.DeliveryTime];
        }



        /// <summary>
        /// Метод заполняет поля формы при нажатии элемента таблицы.
        /// </summary>
        private void InformationTable_SelectionChanged(object sender, EventArgs e)
        {
            var index = informationTable.CurrentRow.Index;
            if (index >= 0)
            {
                ordersItemsListBox.Items.Clear();
                if (Orders[index].GetType() == typeof(Order))
                {
                    FillBasicOrder(Orders[index]);
                    priorityPanel.Visible = false;
                }
                else if (Orders[index].GetType() == typeof(PriorityOrder))
                {
                    FillPriorityOrder((PriorityOrder)Orders[index]);
                    priorityPanel.Visible = true;
                }
            }
        }

        /// <summary>
        /// Выполняется при запуске формы. Он заполняет ComboBox.
        /// </summary>
        private void OrdersTab_Load(object sender, EventArgs e)
        {
            var values = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in values)
            {
                statusComboBox.Items.Add(status);
            }
            statusComboBox.SelectedIndex = 0;

            var TimeDelivery = Services.EnumGetter.GetDeliveryTime();

            foreach (var item in TimeDelivery)
            {
                deliveryTimeComboBox.Items.Add(item.Value);
            }
        }

        /// <summary>
        /// Обновляет тип заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (informationTable.CurrentRow != null)
            {
                var index = informationTable.CurrentRow.Index;
                if (index >= 0)
                {
                    Orders[index].OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus),
                        statusComboBox.SelectedItem.ToString());
                }
            }
        }

        /// <summary>
        /// Изменяет время доставки заказа.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (informationTable.CurrentRow != null)
            {
                var index = informationTable.CurrentRow.Index;
                if (index >= 0)
                {
                    if (Orders[index].GetType() == typeof(PriorityOrder))
                    {
                        var order = (PriorityOrder)Orders[index];
                        var dict = Services.EnumGetter.GetDeliveryTime();
                        foreach (var time in dict)
                        {
                            if (time.Value == deliveryTimeComboBox.SelectedItem.ToString())
                            {
                                order.DeliveryTime = time.Key;
                                break;
                            }
                        }
                        Orders[index] = order;
                    }
                }
            }
        }
    }
}
