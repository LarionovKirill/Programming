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
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        /// <summary>
        /// Свойство для поля _flightTime.
        /// </summary>
        public int flight_time
        {
            set
            {
                if (value > 0 && value < 800)
                {
                    _flightTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _flightTime;
            }
        }

        /// <summary>
        /// Свойсвто для поля _destination.
        /// </summary>
        public string destination
        {
            set
            {
                _destination = value;
            }
            get
            {
                return _destination;
            }
        }

        /// <summary>
        /// Свойство для поля _departurePoint.
        /// </summary>
        public string departurePoint
        {
            set
            {
                _departurePoint = value;
            }
            get
            {
                return _departurePoint;
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
        /// <param name="_departurePoint">Устанавливет значение для поля _departurePoint.</param>
        /// <param name="_destination">Устанавливет значение для поля _destination.</param>
        /// <param name="_flightTime">Устанавливет значение для поля _flightTime.</param>
        public Flight(string _departurePoint , string _destination, int _flightTime)
        {
            this.departurePoint = _departurePoint;
            this.destination = _destination;
            this.flight_time = _flightTime;
        }
    }
}
