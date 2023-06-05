using System;

namespace OOP.Model.EventsArgs
{
    /// <summary>
    /// Класс хранит новую информацию об адресе доставки.
    /// </summary>
    public class AddressEventsArgs : EventArgs
    {
        /// <summary>
        /// Свойстов новой страны доставки.
        /// </summary>
		public string NewCountry { get; set; }

        /// <summary>
        /// Свойство нового города доставки.
        /// </summary>
        public string NewCity { get; set; }

        /// <summary>
        /// Свойство новой улицы для доставки.
        /// </summary>
        public string NewStreet { get; set; }

        /// <summary>
        /// Свойство нового здания для доставки.
        /// </summary>
        public string NewBuilding { get; set; }

        /// <summary>
        /// Свойство новой квартиры для доставки.
        /// </summary>
        public string NewApartment { get; set; }

        /// <summary>
        /// Свойство нового почтового индекса.
        /// </summary>
        public int NewIndex { get; set; }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public AddressEventsArgs()
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
        public AddressEventsArgs(
            int index,
            string country,
            string city,
            string street,
            string building,
            string apartment)
        {
            NewIndex = index;
            NewCountry = country;
            NewCity = city;
            NewStreet = street;
            NewBuilding = building;
            NewApartment = apartment;
        }
    }
}
