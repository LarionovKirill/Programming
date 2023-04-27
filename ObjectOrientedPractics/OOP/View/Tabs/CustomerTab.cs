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
        /// Список пользователей.
        /// </summary>
        private List<Model.Customer> _customers = new List<Model.Customer>();

        /// <summary>
        /// Свойство поля _customers.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public CustomerTab()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Обработка нажатия выбранного пользователя.
        /// </summary>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex>=0)
            {
                var index = customerListBox.SelectedIndex;
                FillFieldsOfCustomer(Customers[index]);
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
            addressControl.postIndexTextBox.Text = current.Address.Index.ToString();
            addressControl.streetTextBox.Text = current.Address.Street;
            addressControl.cityTextBox.Text = current.Address.City;
            addressControl.countryTextBox.Text = current.Address.Country;
            addressControl.buildingTextBox.Text = current.Address.Building;
            addressControl.apartmentTextBox.Text = current.Address.Apartment;
        }

        /// <summary>
        /// Добавляет пользователя в список.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customers.Add(new Model.Customer(
                    fullNameTextBox.Text,
                    int.Parse(addressControl.postIndexTextBox.Text),
                    addressControl.countryTextBox.Text,
                    addressControl.cityTextBox.Text,
                    addressControl.streetTextBox.Text,
                    addressControl.buildingTextBox.Text,
                    addressControl.apartmentTextBox.Text));

                customerListBox.Items.Add($"Пользователь : {Customers.Last().Id}");
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

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Services.ValueValidator.AssertStringOnLength(
                    fullNameTextBox.Text,
                    200,
                    nameof(FullNameTextBox_TextChanged));
                fullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                fullNameTextBox.BackColor = Color.Pink;
            }
        }
    }
}
