using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Свойство поля _customers.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers{get;set;}

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
                foreach(var customers in Customers)
                {
                    customerListBox.Items.Add(customers.FullName);
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
        }

        /// <summary>
        /// Добавляет пользователя в список.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Address currentAddress = GetAddress();
                Customers.Add(new Model.Customer(
                    fullNameTextBox.Text,
                    currentAddress.Index,
                    currentAddress.Building,
                    currentAddress.City,
                    currentAddress.Country,
                    currentAddress.Street,
                    currentAddress.Apartment));

                customerListBox.Items.Add($"Пользователь : {Customers.Last().Id}");
                var index = customerListBox.SelectedIndex;
                if (index >= 0)
                {
                    addressControl.GetCustomer(index);
                }

            }
            catch
            {
                MessageBox.Show("Введите верные значения.");
            }
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
            }
        }

        /// <summary>
        /// Изменяет полное имя пользователя.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (customerListBox.SelectedIndex >= 0)
                {
                    var index = customerListBox.SelectedIndex;
                    Customers[index].FullName = fullNameTextBox.Text;
                }
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
    }
}
