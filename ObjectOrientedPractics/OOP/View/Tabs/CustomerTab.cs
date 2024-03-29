﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OOP.Model.Enums;
using OOP.Model.Discounts;

namespace OOP.View
{
    /// <summary>
    /// Логика пользовательского объекта.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Свойство поля _customers.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers { get; set; }

        /// <summary>
        /// Показатель режима изменения.
        /// </summary>
        private bool ChangeMode { get; set; } = false;

        /// <summary>
        /// Показатель режима добавления.
        /// </summary>
        private bool AddMode { get; set; } = false;

        /// <summary>
        /// Копия пользователя.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Model.Customer Copy { get; set; } = new Model.Customer();

        public CustomerTab()
        {
            InitializeComponent();
            addressControl._customerTab = this;
        }

        /// <summary>
        /// Обновляет информацию о пользователе.
        /// </summary>
        public void UpdateInformation()
        {
            if (Customers != null)
            {
                foreach (var customers in Customers)
                {
                    customerListBox.Items.Add(customers.FullName);

                    AddressControl control = new AddressControl();
                    customers.Address.AddressChanged += control.FillNewAddress;
                }
            }
        }

        /// <summary>
        /// Обработка нажатия выбранного пользователя.
        /// </summary>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                FillFieldsOfCustomer(Customers[index]);
                addressControl.GetCustomer(index);
                addressControl.FillAddress(Customers[index].Address);
                FillDiscounts(Customers[index]);
                if (ChangeMode == true)
                {
                    CloseFields();
                }
            }
        }

        /// <summary>
        /// Заполняет поля данными из класса.
        /// </summary>
        /// <param name="current">Передаваемый класс с информацией о пользователе.</param>
        public void FillFieldsOfCustomer(Model.Customer current)
        {
            idCustomerTextBox.Text = current.Id.ToString();
            fullNameTextBox.Text = current.FullName;
            isPriorityCheckBox.Checked = current.IsPriority;
        }

        /// <summary>
        /// Добавляет пользователя в список.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddMode = true;
            ClearFields();
            customerListBox.SelectedIndex = -1;
            OpenFields();
        }

        /// <summary>
        /// Удаляет пользователя из списка.
        /// </summary>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                Customers.RemoveAt(index);
                customerListBox.Items.RemoveAt(index);
                customerListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Изменяет полное имя пользователя.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Copy.FullName = fullNameTextBox.Text;
                fullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                fullNameTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Возвращает адрес из другой формы.
        /// </summary>
        /// <returns>Адрес.</returns>
        private Model.Address GetAddress()
        {
            return addressControl.Address;
        }

        /// <summary>
        /// Изменяет значение приоритета пользователя.
        /// </summary>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                if (isPriorityCheckBox.Checked)
                {
                    Customers[index].IsPriority = true;
                }
                else
                {
                    Customers[index].IsPriority = false;
                }
            }
        }

        /// <summary>
        /// Дает возможность изменить данные.
        /// </summary>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                OpenFields();
                Customers[index].CopyInformation(Copy);
                ChangeMode = true;
            }
            else
            {
                MessageBox.Show("Выберите пользователя.");
            }
        }

        /// <summary>
        /// Открывает поля.
        /// </summary>
        private void OpenFields()
        {
            saveButton.Visible = true;
            cancelButton.Visible = true;
            fullNameTextBox.ReadOnly = false;
            addressControl.Enabled = true;
        }

        /// <summary>
        /// Закрывает поля.
        /// </summary>
        private void CloseFields()
        {
            saveButton.Visible = false;
            cancelButton.Visible = false;
            fullNameTextBox.ReadOnly = true;
            addressControl.Enabled = false;
            ChangeMode = false;
            AddMode = false;
        }

        /// <summary>
        /// Кнопка сохраняет изменения.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            addressControl.DeleteCustomer();
            if (AddMode)
            {
                try
                {
                    Model.Address currentAddress = GetAddress();
                    if (currentAddress == null || !addressControl.IsColorWhite())
                    {
                        MessageBox.Show("Введите верные значения.");
                        ClearFields();
                        CloseFields();
                        return;
                    }
                    Customers.Add(new Model.Customer(
                        fullNameTextBox.Text,
                        currentAddress.Index,
                        currentAddress.Building,
                        currentAddress.City,
                        currentAddress.Country,
                        currentAddress.Street,
                        currentAddress.Apartment));

                    customerListBox.Items.Add(Customers.Last().FullName);
                }
                catch
                {
                    MessageBox.Show("Введите верные значения.");
                }
            }
            else if (ChangeMode)
            {
                var index = customerListBox.SelectedIndex;
                if (fullNameTextBox.BackColor == Color.White &&
                    addressControl.IsColorWhite())
                {
                    Copy.CopyInformation(Customers[index]);
                    addressControl.DeleteCustomer();
                    customerListBox.Items.Insert(index, Customers[index].FullName);
                    customerListBox.Items.RemoveAt(index + 1);
                    ClearFields();
                    MessageBox.Show("Данные успешно сохранены.");
                }
                else
                {
                    MessageBox.Show("Мы не можем сохранить такие данные.");
                }
                customerListBox.SelectedIndex = -1;
            }
            CloseFields();
        }

        /// <summary>
        /// Кнопка отменяет изменения.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseFields();
            ClearFields();
            addressControl.DeleteCustomer();
            MessageBox.Show("Изменения не были сохранены");
            customerListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearFields()
        {
            fullNameTextBox.Text = string.Empty;
            idCustomerTextBox.Text = string.Empty;
            addressControl.ClearFieldAddress();
        }

        /// <summary>
        /// Заполняет listbox скидками пользователя.
        /// </summary>
        /// <param name="currentCustomer">Переданный пользователь.</param>
        private void FillDiscounts(Model.Customer currentCustomer)            
        {
            discountListBox.Items.Clear();
            foreach (var discounts in currentCustomer.Discounts)
            {
                discountListBox.Items.Add(discounts.Info);
            }
        }

        /// <summary>
        /// Метод переводит на форму с добавлением формы.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                Forms.AddDiscountForm form = new Forms.AddDiscountForm();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    var result = form.discountsComboBox.SelectedItem.ToString();
                    foreach (var checkCategory in Customers[index].Discounts)
                    {
                        if (checkCategory.GetType() == typeof(PercentDiscount))
                        {
                            var discount = (PercentDiscount)checkCategory;
                            if (discount.DiscountItemCategory.ToString() == result)
                            {
                                MessageBox.Show("Данная скидка у вас уже имеется");
                                return;
                            }
                        }
                    }
                    var category = Enum.GetValues(typeof(ItemCategory));
                    foreach (var item in category)
                    {
                        if (result == item.ToString())
                        {
                            Customers[index].Discounts.Add(new PercentDiscount((ItemCategory)item));
                            FillDiscounts(Customers[index]);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали пользователя.");
            }
        }

        /// <summary>
        /// Удаляет скидку из списка товаров.
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (discountListBox.SelectedIndex>=0 && customerListBox.SelectedIndex>=0)
            {
                if (discountListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Накопительная скидка обязательна. Ее нельзя удалить.");
                }
                else
                {
                    var indexCustomer = customerListBox.SelectedIndex;
                    var indexDiscount = discountListBox.SelectedIndex;
                    Customers[indexCustomer].Discounts.RemoveAt(indexDiscount);
                    FillDiscounts(Customers[indexCustomer]);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали скидку или пользователя");
            }
        }

        /// <summary>
        /// Заполняет поля при переходе из другого окна.
        /// </summary>
        public void Fill()
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                FillDiscounts(Customers[customerListBox.SelectedIndex]);
            }
        }
    }
}
