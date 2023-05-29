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
                    AddPointsToCustomer(newOrder);
                }
                else
                {
                    Order newOrder = new Order(
                        DateTime.Now,
                        CurrentCustomer.Address,
                        OrderStatus.New);
                    AddPointsToCustomer(newOrder);
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
                ClearCost();
            }
        }

        /// <summary>
        /// Заполняет listbox скидками пользователя.
        /// </summary>
        /// <param name="currentCustomer">Переданный пользователь.</param>
        private void FillDiscounts(Model.Customer currentCustomer)
        {
            var discountsCounter = 0;
            discountsCheckedListBox.Items.Clear();
            foreach (var discounts in currentCustomer.Discounts)
            {
                discountsCheckedListBox.Items.Add(discounts.Info);
                discountsCheckedListBox.SetItemChecked(discountsCounter, true);
                discountsCounter++;
            }
        }

        /// <summary>
        /// Метод считает скидку выбранную пользователем.
        /// </summary>
        /// <returns>Размер скидки.</returns>
        private decimal CalculateDiscountCost()
        {
            decimal sale = 0;
            var discounts = discountsCheckedListBox.CheckedItems;
            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                if (discounts.Contains(CurrentCustomer.Discounts[i].Info))
                {
                    sale += 
                        CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.ListOfGoods);
                }
            }
            discountCostLabel.Text = sale.ToString();
            return sale;
        }

        /// <summary>
        /// Метод считает итоговую стоимость.
        /// </summary>
        private void CalculateTotalCost()
        {
            var sale = CalculateDiscountCost();
            var price = CurrentCustomer.Cart.Amount;
            totalCostLabel.Text = (price - sale).ToString();
        }

        /// <summary>
        /// Метод обрабатывает заказ и начисляет скидку пользователю.
        /// </summary>
        /// <param name="newOrder">Созданный заказ.</param>
        private void AddPointsToCustomer(Order newOrder)
        {
            newOrder.Items.AddRange(CurrentCustomer.Cart.ListOfGoods);
            newOrder.DiscountAmount = newOrder.FullCost - CalculateDiscountCost();
            CurrentCustomer.Orders.Add(newOrder);
            foreach (var discount in CurrentCustomer.Discounts)
            {
                if (typeof(PointsDiscount) == discount.GetType())
                {
                    var tempDiscount = (PointsDiscount)discount;
                    tempDiscount.Discount = decimal.Parse(discountCostLabel.Text);
                    tempDiscount.Update(CurrentCustomer.Cart.ListOfGoods);
                }
                else
                {
                    discount.Update(CurrentCustomer.Cart.ListOfGoods);
                }
            }

            //Очищение корзины.
            CurrentCustomer.Cart.ListOfGoods.Clear();
            cartListBox.Items.Clear();
            amountPriceLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            customerComboBox.SelectedIndex = -1;
            discountsCheckedListBox.Items.Clear();
            ClearCost();
        }

        /// <summary>
        /// Метод обрабатывает нажатие скидки и меняет стоимость заказа.
        /// </summary>
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        /// <summary>
        /// Очищает стоимость корзины.
        /// </summary>
        private void ClearCost()
        {
            totalCostLabel.Text = 0.0m.ToString();
            discountCostLabel.Text = 0.0m.ToString();
        }
    }
}
