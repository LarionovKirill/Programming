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
    public class Address : ICloneable, IEquatable<Address>
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
        public Address(
            int index, 
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

        /// <summary>
        /// Реализация копирования от стандартного интерфейса ICloneable.
        /// </summary>
        /// <returns>Возвращает копию объекта класса <see cref="Address"/>.</returns>
        public object Clone()
        {
            return new Address(
                this.Index,
                this.Country,
                this.City,
                this.Street,
                this.Building,
                this.Apartment);
        }

        /// <summary>
        /// Перегрузка метода Equals.
        /// </summary>
        /// <param name="other">Сравниваемый объект.</param>
        /// <returns>True, если равны, иначе false.</returns>
        public override bool Equals(object other)
        {
            //Проверка на наличие объекта.
            if (other == null)
            {
                return false;
            }

            //Проверка на один тип.
            if (other.GetType() != typeof(Address))
            {
                return false;
            }

            //Проверка на одинаковые ссылки.
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var address2 = (Address)other;

            return (
                this.Index == address2.Index &&
                this.Street == address2.Street &&
                this.Building == address2.Building);
        }

        /// <summary>
        /// Перегрузка метода Equals.
        /// </summary>
        /// <param name="other">Сравниваемый объект типа Address.</param>
        /// <returns>True, если равны индекс, улица и здание, иначе False.</returns>
        public bool Equals(Address other)
        {
            return (
                this.Index == other.Index &&
                this.Street == other.Street &&
                this.Building == other.Building);
        }
    }
}
