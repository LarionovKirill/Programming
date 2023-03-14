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
        private int Hour;
        private int Minute;
        private int Second;

        /// <summary>
        /// Свойство для поля Hour.
        /// </summary>
        public int hour
        {
            set
            {
                if (value >= 0 && value <= 23)
                {
                    Hour = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Hour;
            }
        }

        /// <summary>
        /// Свойство для поля Minute.
        /// </summary>
        public int minute
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    Minute = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Minute;
            }
        }

        /// <summary>
        /// Свойство для поля Second.
        /// </summary>
        public int second
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    Second = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Second;
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
        /// <param name="Hour">Устанавливает значение в поле Hour.</param>
        /// <param name="Minute">Устанавливает значение в поле Minute.</param>
        /// <param name="Second">Устанавливает значение в поле Second.</param>
        public Time(int Hour, int Minute, int Second)
        {
            this.hour = Hour;
            this.minute = Minute;
            this.second = Second;
        }
    }
}
