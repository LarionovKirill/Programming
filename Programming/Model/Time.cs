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
                try
                {
                    Validator checker = new Validator();
                    checker.AssertValueInRange(value, 0, 23);
                    _hour = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set") + 4;
                    string error = string.Empty;
                    for (int i = index; i < index + 4; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
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
        public int Minute
        {
            set
            {
                try
                {
                    Validator checker = new Validator();
                    checker.AssertValueInRange(value, 0, 59);
                    _minute = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set") + 4;
                    string error = string.Empty;
                    for (int i = index; i < index + 6; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
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
        public int Second
        {
            set
            {
                try
                {
                    Validator checker = new Validator();
                    checker.AssertValueInRange(value, 0, 59);
                    _second = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set") + 4;
                    string error = string.Empty;
                    for (int i = index; i < index + 6; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
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
