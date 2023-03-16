﻿using System;
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
        public int Flight_time
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
        public string Destination { get; set; }

        /// <summary>
        /// Свойство для поля _departurePoint.
        /// </summary>
        public string DeparturePoint { get; set; }

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
            this.DeparturePoint = _departurePoint;
            this.Destination = _destination;
            this.Flight_time = _flightTime;
        }
    }
}
