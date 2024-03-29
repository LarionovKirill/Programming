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
        /// <summary>
        /// Хранит пункт отправки.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Хранит пункт назначения. 
        /// </summary>
        private string _destination;

        /// <summary>
        /// Хранит время полёта.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Свойство для поля _flightTime.
        /// </summary>
        public int FlightTime
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 800, nameof(FlightTime));
                _flightTime = value;
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
        /// <param name="departurePoint">Устанавливет значение для поля _departurePoint.</param>
        /// <param name="destination">Устанавливет значение для поля _destination.</param>
        /// <param name="flightTime">Устанавливет значение для поля _flightTime.</param>
        public Flight(string departurePoint , string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}
