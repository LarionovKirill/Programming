using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Класс хранит информацию об адресе пользователя.
    /// </summary>
    [Serializable]
    public class Address
    {
        /// <summary>
        /// Почтовый индекс пользователя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна пользователя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город пользователя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица пользователя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Здание пользователя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Квартира пользователя.
        /// </summary>
        private string _apartment;
        
        /// <summary>
        /// Свойство поля _index.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                Services.ValueValidator.AssertIndex(value, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Свойство поля _country.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Свойство поля _city.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Свойство поля _street.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Свойство поля _building.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Свойство поля _apartment.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Здание.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, 
            string country, 
            string city, 
            string street, 
            string building, 
            string apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Building = building;
            this.Apartment = apartment;
        }
    }
}
