using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTask.Model
{
    /// <summary>
    /// Класс авиаперелетов.
    /// </summary>

    [Serializable]
    class AirTravel
    {
        /// <summary>
        /// Пункт отправления.
        /// </summary>
        private string _departure;

        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Время вылета.
        /// </summary>
        private DateTime _departureTime;

        /// <summary>
        /// Время полета.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Тип перелета.   
        /// </summary>
        private FlightType _flightType;

        /// <summary>
        /// Свойство поля _departure.
        /// </summary>
        public string Departure
        {
            get
            {
                return _departure;
            }
            set
            {
                Services.ColissionManager.AssertOnLengthOfString(
                    value,
                    100,
                    "Длина строки не должна превышать 100 символов.");
                _departure = value;
            }
        }


        /// <summary>
        /// Свойство поля _destination.
        /// </summary>
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                Services.ColissionManager.AssertOnLengthOfString(
                    value,
                    100,
                    "Destination");
                _destination = value;
            }
        }

        /// <summary>
        /// Свойство поля _departureTime
        /// </summary>
        public DateTime DepartureTime
        {
            set
            {
                Services.ColissionManager.AssertDepartureTime(
                    value,
                    "DepartureTime");
                _departureTime = value;
            }
            get
            {
                return _departureTime;
            }
        }

        /// <summary>
        /// Свойство поля _flightTime.
        /// </summary>
        public int FlightTime
        {
            set
            {
                Services.ColissionManager.AssertFlightTime(
                    value,
                    1000,
                    "FlightTime");
                _flightTime = value;
            }
            get
            {
                return _flightTime;
            }
        }

        /// <summary>
        /// Свойство поля _flightType.
        /// </summary>
        public FlightType FlightType
        {
            set
            {
                Services.ColissionManager.IsValueInEnum(
                    value,
                    "FlightType");
                _flightType = value;
            }
            get
            {
                return _flightType;
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public AirTravel()
        {
            
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="departureTime">Время вылета.</param>
        /// <param name="_flightTime">Время полета.</param>
        /// <param name="_flightType">Тип полета.</param>
        public AirTravel(
            string departure, 
            string destination,
            DateTime departureTime,
            int flightTime,
            FlightType flightType
            )
        {
            this.Destination = destination;
            this.Departure = departure;
            this.DepartureTime = departureTime;
            this.FlightTime = flightTime;
            this.FlightType = flightType;
        }
    }
}
