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
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Копия формы для передачи данных
        /// </summary>
        public CustomerTab CustomerTab { get; set; }

        /// <summary>
        /// Хранит преедан пользователь или нет.
        /// </summary>
        private bool CurrentCustomer { get; set; } = false;

        /// <summary>
        /// Хранит индекс переданного пользователя.
        /// </summary>
        private int Index { get; set; }


        /// <summary>
        /// Свойство адреса.
        /// </summary>
        public Model.Address Address{ get; set;}

        /// <summary>
        /// Метод заполняет поля адреса.
        /// </summary>
        internal void FillAddress(Model.Address address)
        {
            postIndexTextBox.Text = address.Index.ToString();
            countryTextBox.Text = address.Country;
            cityTextBox.Text = address.City;
            apartmentTextBox.Text = address.Apartment;
            buildingTextBox.Text = address.Building;
            streetTextBox.Text = address.Street;
        }


        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка индекса на правильный ввод. 
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.Index = int.Parse(postIndexTextBox.Text);
                postIndexTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.Index = Address.Index;
                }
            }
            catch
            {
                postIndexTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверка страны на правильный ввод.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.Country = Address.Country;
                }
            }
            catch
            {
                countryTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверка улицы на правильный ввод.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.City = Address.City;
                }
            }
            catch
            {
                cityTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверка улицы на правильный ввод.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.Street = Address.Street;
                }
            }
            catch
            {
                streetTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверка здания на правильный ввод.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.Building = Address.Building;
                }
            }
            catch
            {
                buildingTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверка квартиры на правильный ввод.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Address == null)
                {
                    Address = new Model.Address();
                }
                Address.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = Color.White;
                if (CurrentCustomer)
                {
                    CustomerTab.Customers[Index].Address.Apartment = Address.Apartment;
                }
            }
            catch
            {
                apartmentTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Получение объекта, которого выбрали в другом элемента.
        /// </summary>
        /// <param name="current">Выбранный пользователь с другого элемента.</param>
        public void GetCustomer(int index)
        {
            CurrentCustomer = true;
            Index = index;
        }
    }
}
