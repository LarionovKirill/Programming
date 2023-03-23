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
        /// <summary>
        /// Хранит кол-во часов.
        /// </summary>
        private int _hour;

        /// <summary>
        /// Хранит кол-во минут.
        /// </summary>
        private int _minute;

        /// <summary>
        /// Хранит кол-во секунд.
        /// </summary>
        private int _second;

        /// <summary>
        /// Свойство для поля _hour.
        /// </summary>
        public int Hour
        {
            set
            {
                Validator checker = new Validator();
                checker.AssertValueInRange(value, 0, 23, nameof(Hour));
                _hour = value;
            }
            get
            {
                return _hour;
            }
        }

        /// <summary>
        /// Свойство для поля _minute.
        /// </summary>
        public int Minute
        {
            set
            {
                Validator checker = new Validator();
                checker.AssertValueInRange(value, 0, 59, nameof(Minute));
                _minute = value;
            }
            get
            {
                return _minute;
            }
        }

        /// <summary>
        /// Свойство для поля _second.
        /// </summary>
        public int Second
        {
            set
            {
                Validator checker = new Validator();
                checker.AssertValueInRange(value, 0, 59, nameof(Second));
                _second = value;
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
        /// <param name="hour">Устанавливает значение в поле _hour.</param>
        /// <param name="minute">Устанавливает значение в поле _minute.</param>
        /// <param name="second">Устанавливает значение в поле _second.</param>
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
    }
}
