using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using OOP.Model.Orders;
using OOP.Model.Enums;
using OOP.Model.Discounts;

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
                FillDiscounts(Customers[selectedIndex]);
                CurrentCustomer = Customers[selectedIndex];
                if (CurrentCustomer.Cart.ListOfGoods != null)
                {
                    foreach (var items in CurrentCustomer.Cart.ListOfGoods)
                    {
                        cartListBox.Items.Add(items.Name);
                    }
                }
                amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                CalculateDiscountCost();
                CalculateTotalCost();
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
                CalculateDiscountCost();
                CalculateTotalCost();
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
                CalculateDiscountCost();
                CalculateTotalCost();
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
                    PriorityOrder newOrder = new PriorityOrder(
                        CurrentCustomer.Address,
                        OrderStatus.New,
                        DateTime.Now);
                    newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
                    CurrentCustomer.Orders.Add(newOrder);
                    if (CurrentCustomer.Discounts.GetType() == typeof(PointsDiscount))
                    {
                        var indexDiscount = CurrentCustomer.Discounts.Count;
                        var temp = (PointsDiscount)CurrentCustomer.Discounts[indexDiscount-1];
                        temp.Discount = decimal.Parse(discountCostLabel.Text);
                    }
                    newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
                    CurrentCustomer.Orders.Add(newOrder);
                    
                    //Очищение корзины.
                    CurrentCustomer.Cart.ListOfGoods.Clear();
                    cartListBox.Items.Clear();
                    amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                    customerComboBox.SelectedIndex = 0;
                    FillDiscounts(Customers[0]);
                }
                else
                {
                    Order newOrder = new Order(
                        DateTime.Now,
                        CurrentCustomer.Address,
                        OrderStatus.New);
                    newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
                    CurrentCustomer.Orders.Add(newOrder);
                    foreach (var discount in CurrentCustomer.Discounts)
                    {
                        if (discount.GetType() == typeof(PointsDiscount))
                        {
                            var temp = (PointsDiscount)discount;
                            temp.Discount = decimal.Parse(discountCostLabel.Text);
                        }
                        discount.Update(CurrentCustomer.Cart.ListOfGoods);
                    }

                    //Очищение корзины.
                    CurrentCustomer.Cart.ListOfGoods.Clear();
                    cartListBox.Items.Clear();
                    amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                    CalculateDiscountCost();
                    CalculateTotalCost();
                    customerComboBox.SelectedIndex = 0;
                    FillDiscounts(Customers[0]);
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

        /// <summary>
        /// Заполняет listbox скидками пользователя.
        /// </summary>
        /// <param name="currentCustomer">Переданный пользователь.</param>
        private void FillDiscounts(Model.Customer currentCustomer)
        {
            var a = 0;
            discountsCheckedListBox.Items.Clear();
            foreach (var discounts in currentCustomer.Discounts)
            {
                discountsCheckedListBox.Items.Add(discounts.Info);
                discountsCheckedListBox.SetItemChecked(a, true);
                a++;
            }
        }

        /// <summary>
        /// Метод считает скидку.
        /// </summary>
        private void CalculateDiscountCost()
        {
            decimal sale = 0;
            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                sale += CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.ListOfGoods);
            }
            discountCostLabel.Text = sale.ToString();
        }

        /// <summary>
        /// Метод считает итоговую стоимость.
        /// </summary>
        private void CalculateTotalCost()
        {
            var sale = decimal.Parse(discountCostLabel.Text);
            var price = decimal.Parse(amountPriceLabel.Text);
            totalCostLabel.Text = (price - sale).ToString();
        }
    }
}
