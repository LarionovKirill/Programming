using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        /// <summary>
        /// Свойство для поля _hour.
        /// </summary>
        public int hour
        {
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _hour;
            }
        }

        /// <summary>
        /// Свойство для поля _minute.
        /// </summary>
        public int minute
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _minute;
            }
        }

        /// <summary>
        /// Свойство для поля _second.
        /// </summary>
        public int second
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _second = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _second;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_hour">Устанавливает значение в поле _hour.</param>
        /// <param name="_minute">Устанавливает значение в поле _minute.</param>
        /// <param name="_second">Устанавливает значение в поле _second.</param>
        public Time(int _hour, int _minute, int _second)
        {
            this.hour = _hour;
            this.minute = _minute;
            this.second = _second;
        }
    }
}
