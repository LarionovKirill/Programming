using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP.Model.EventsArgs;

namespace OOP.View
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Копия формы для передачи данных
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CustomerTab _customerTab;

        /// <summary>
        /// Хранит передан пользователь или нет.
        /// </summary>
        private bool _currentCustomer = false;

        /// <summary>
        /// Свойство адреса.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        /// <summary>
        /// Метод заполняет поля адреса.
        /// </summary>
        public void FillNewAddress(object sender, EventArgs e)
        {
            if (e is AddressEventsArgs)
            {
                var address = (AddressEventsArgs)e;
                postIndexTextBox.Text = address.NewIndex.ToString();
                countryTextBox.Text = address.NewCountry;
                cityTextBox.Text = address.NewCity;
                apartmentTextBox.Text = address.NewApartment;
                buildingTextBox.Text = address.NewBuilding;
                streetTextBox.Text = address.NewStreet;
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
                if (Address == null)
                {
                    Address = new Model.Address();
                    Address.AddressChanged += FillNewAddress;
                }
                if (postIndexTextBox.Text != string.Empty)
                {
                    Address.Index = int.Parse(postIndexTextBox.Text);
                    postIndexTextBox.BackColor = Color.White;
                    if (_currentCustomer)
                    {
                        _customerTab.Copy.Address.Index = Address.Index;
                    }
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
                    Address.AddressChanged += FillNewAddress;
                }
                Address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
                if (_currentCustomer)
                {
                    _customerTab.Copy.Address.Country = Address.Country;
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
                    Address.AddressChanged += FillNewAddress;
                }
                Address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
                if (_currentCustomer)
                {
                    _customerTab.Copy.Address.City = Address.City;
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
                    Address.AddressChanged += FillNewAddress;
                }
                Address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
                if (_currentCustomer)
                {
                    _customerTab.Copy.Address.Street = Address.Street;
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
                    Address.AddressChanged += FillNewAddress;
                }
                Address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
                if (_currentCustomer)
                {
                    _customerTab.Copy.Address.Building = Address.Building;
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
                    Address.AddressChanged += FillNewAddress;
                }
                Address.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = Color.White;
                if (_currentCustomer)
                {
                    _customerTab.Copy.Address.Apartment = Address.Apartment;
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
        /// <param name="index">Индекс выбранного пользователя с другого элемента.</param>
        public void GetCustomer(int index)
        {
            _currentCustomer = true;
        }

        /// <summary>
        /// Удаляет пользователя.
        /// </summary>
        public void DeleteCustomer()
        {
            _currentCustomer = false;
        }

        /// <summary>
        /// Очищает поля адреса.
        /// </summary>
        public void ClearFieldAddress()
        {
            postIndexTextBox.Text = string.Empty;
            countryTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            streetTextBox.Text = string.Empty;
            buildingTextBox.Text = string.Empty;
            apartmentTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Проверяет, все ли поля адреса белые(Значит валидация прошла успешно).
        /// </summary>
        /// <returns>True - все поля белые, иначе False.</returns>
        public bool IsColorWhite()
        {
            return (
                postIndexTextBox.BackColor == Color.White &&
                countryTextBox.BackColor == Color.White &&
                cityTextBox.BackColor == Color.White &&
                streetTextBox.BackColor == Color.White &&
                buildingTextBox.BackColor == Color.White &&
                apartmentTextBox.BackColor == Color.White);
        }
    }
}
