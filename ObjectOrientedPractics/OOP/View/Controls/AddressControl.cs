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
        private List<Model.Address> _address = new List<Model.Address>();
       
        /// <summary>
        /// Свойство для списка _address.
        /// </summary>
        private List<Model.Address> Address { set; get; }

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
                Services.ValueValidator.AssertIndex(
                    int.Parse(postIndexTextBox.Text),
                    nameof(PostIndexTextBox_TextChanged));
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
                Services.ValueValidator.AssertStringOnLength(
                    countryTextBox.Text,
                    50,
                    nameof(CountryTextBox_TextChanged));
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
                Services.ValueValidator.AssertStringOnLength(
                    cityTextBox.Text,
                    50,
                    nameof(CityTextBox_TextChanged));
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
                Services.ValueValidator.AssertStringOnLength(
                    streetTextBox.Text,
                    100,
                    nameof(StreetTextBox_TextChanged));
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
                Services.ValueValidator.AssertStringOnLength(
                    buildingTextBox.Text,
                    10,
                    nameof(BuildingTextBox_TextChanged));
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
                Services.ValueValidator.AssertStringOnLength(
                    apartmentTextBox.Text,
                    10,
                    nameof(ApartmentTextBox_TextChanged));
                apartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                apartmentTextBox.BackColor = Color.Pink;
            }
        }
    }
}
