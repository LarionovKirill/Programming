﻿using System;
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
        public List<Model.Order> Orders { get; set; } = new List<Model.Order>();

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
        /// Метод заполняет поля формы при нажатии элемента таблицы.
        /// </summary>
        private void InformationTable_SelectionChanged(object sender, EventArgs e)
        {
            var index = informationTable.CurrentRow.Index;
            if (index >= 0)
            {
                ordersItemsListBox.Items.Clear();
                idTextBox.Text = Orders[index].Id.ToString();
                creationTextBox.Text = Orders[index].DateOfCreate.ToString("dd.MM.yyyy");
                statusComboBox.SelectedItem = Orders[index].OrderStatus;
                var currentAddress = Orders[index].Address;
                addressControl.FillAddress(currentAddress);
                foreach (var items in Orders[index].Items)
                {
                    ordersItemsListBox.Items.Add(items.Name);
                }
                costLabel.Text = Orders[index].FullCost.ToString();
            }
        }

        /// <summary>
        /// Выполняется при запуске формы. Он заполняет ComboBox.
        /// </summary>
        private void OrdersTab_Load(object sender, EventArgs e)
        {
            var values = Enum.GetValues(typeof(Model.OrderStatus));
            foreach (var status in values)
            {
                statusComboBox.Items.Add(status);
            }
            statusComboBox.SelectedIndex = 0;
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
                    Orders[index].OrderStatus = (Model.OrderStatus)Enum.Parse(typeof(Model.OrderStatus),
                        statusComboBox.SelectedItem.ToString());
                }
            }
        }
    }
}