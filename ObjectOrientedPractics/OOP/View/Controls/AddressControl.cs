using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Список адресов.
        /// </summary>
        private Model.Address _address = new Model.Address();
       
        /// <summary>
        /// Свойство для поля _address.
        /// </summary>
        public Model.Address Address 
        {
            set 
            {
                _address = value;
            }
            get
            {
                return _address;
            }
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
                Address.Index = int.Parse(postIndexTextBox.Text);
                postIndexTextBox.BackColor = Color.White;
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
                Address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
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
                Address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
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
                Address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
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
                Address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
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
                Address.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                apartmentTextBox.BackColor = Color.Pink;
            }
        }
    }
}
