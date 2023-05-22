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
    /// Логика корзины.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит информацию о выбранном пользователе.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Model.Customer CurrentCustomer { get; set;}

        /// <summary>
        /// Свойство для товаров.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Item> Items { get; set; }

        /// <summary>
        /// Свойство пользователей.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers { get; set; }


        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выполняется при выборе пользователя.
        /// </summary>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = customerComboBox.SelectedIndex;
            cartListBox.Items.Clear();
            if (selectedIndex >= 0)
            {
                CurrentCustomer = Customers[selectedIndex];
                if (CurrentCustomer.Cart.ListOfGoods != null)
                {
                    foreach (var items in CurrentCustomer.Cart.ListOfGoods)
                    {
                        cartListBox.Items.Add(items.Name);
                    }
                }
                amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Обновляет информацию на вкладке.
        /// </summary>
        public void RefreshData() 
        {
            //Очистка поля.
            itemsListBox.Items.Clear();
            customerComboBox.Items.Clear();

            //Заполнение полей обновленными значениями.
            foreach (var customer in Customers)
            {
                customerComboBox.Items.Add(customer.FullName);
            }
            foreach (var items in Items)
            {
                itemsListBox.Items.Add(items.Name);
            }
        }

        /// <summary>
        /// Метод добавляет выбранный товар в корзину.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var selectedItem = itemsListBox.SelectedIndex;
            if (selectedItem >= 0 && customerComboBox.SelectedIndex >= 0)
            {
                CurrentCustomer = Customers[customerComboBox.SelectedIndex];
                CurrentCustomer.Cart.ListOfGoods.Add(Items[selectedItem]);
                cartListBox.Items.Add(itemsListBox.SelectedItem);
                amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                MessageBox.Show("Выберите пользователя и товар");
            }
        }

        /// <summary>
        /// Метод удаляет товар из корзины.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var selectedIndexInCart = cartListBox.SelectedIndex;
            if (selectedIndexInCart>=0)
            {
                CurrentCustomer.Cart.ListOfGoods.RemoveAt(selectedIndexInCart);
                cartListBox.Items.RemoveAt(selectedIndexInCart);
                amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Создает экземпляр заказа.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && cartListBox.Items.Count > 0)
            {
                if (CurrentCustomer.IsPriority)
                {
                    Model.PriorityOrder newOrder = new Model.PriorityOrder(
                        CurrentCustomer.Address,
                        Model.OrderStatus.New,
                        DateTime.Now
                        ) ;
                    newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
                    CurrentCustomer.Orders.Add(newOrder);
                    CurrentCustomer.Cart.ListOfGoods.Clear();
                    cartListBox.Items.Clear();
                    amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                }
                else
                {
                    Model.Order newOrder = new Model.Order(
                        DateTime.Now,
                        CurrentCustomer.Address,
                        Model.OrderStatus.New);
                    newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
                    CurrentCustomer.Orders.Add(newOrder);
                    CurrentCustomer.Cart.ListOfGoods.Clear();
                    cartListBox.Items.Clear();
                    amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                }
            }
            else
            {
                MessageBox.Show("Пустая корзина или не выбран пользователь");
            }
        }

        /// <summary>
        /// Очищает корзину.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.ListOfGoods.Clear();
                cartListBox.Items.Clear();
                amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }
    }
}
