using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об времени полета, отправной и конечной точки.
    /// </summary>
    class Flight
    {
        private string DeparturePoint;
        private string Destination;
        private int FlightTime;

        /// <summary>
        /// Свойство для поля FlightTime.
        /// </summary>
        public int flight_time
        {
            set
            {
                if (value > 0 && value < 800)
                {
                    FlightTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return FlightTime;
            }
        }

        /// <summary>
        /// Свойсвто для поля Destination.
        /// </summary>
        public string destination
        {
            set
            {
                Destination = value;
            }
            get
            {
                return Destination;
            }
        }

        /// <summary>
        /// Свойство для поля DeparturePoint.
        /// </summary>
        public string departurePoint
        {
            set
            {
                DeparturePoint = value;
            }
            get
            {
                return DeparturePoint;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="DeparturePoint">Устанавливет значение для поля DeparturePoint.</param>
        /// <param name="Destination">Устанавливет значение для поля Destination.</param>
        /// <param name="FlightTime">Устанавливет значение для поля FlightTime.</param>
        public Flight(string DeparturePoint , string Destination, int FlightTime)
        {
            this.departurePoint = DeparturePoint;
            this.destination = Destination;
            this.flight_time = FlightTime;
        }
    }
}
