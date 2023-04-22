using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTask.Services
{
    /// <summary>
    /// Класс для проверки коллизий.
    /// </summary>
    static class ColissionManager
    {
        /// <summary>
        /// Метод проверяет, содержит ли строка больше символов чем разрешено.
        /// </summary>
        /// <param name="text">Вводимый на проверку текст.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Текст ошибки.</param>
        public static void AssertOnLengthOfString(string text, int maxLength, string propertyName)
        {
            if (text.Length > maxLength)
            {
                throw new ArgumentException(propertyName);
            }
        }

        /// <summary>
        /// Метод проверяет, что время полета находится в правильном отрезке.
        /// </summary>
        /// <param name="flightTime">Время полета.</param>
        /// <param name="maxTime">Максимально допустимое время полета.</param>
        /// <param name="propertyName">Текст ошибки.</param>
        public static void AssertFlightTime (int flightTime, int maxTime, string propertyName)
        {
            if (flightTime <= 0 || flightTime > maxTime)
            {
                throw new ArgumentException(propertyName);
            }
        }

        /// <summary>
        /// Проверяет правильность ввода времени вылета.
        /// </summary>
        /// <param name="departureFlight">Передаваемое время вылета.</param>
        /// <param name="properyName">Текст ошибки.</param>
        public static void AssertDepartureTime(DateTime departureFlight, string properyName)
        {
            DateTime currentTime;
            currentTime = DateTime.Now.Date;
            if (departureFlight.Date < currentTime.Date)
            {
                throw new ArgumentException(properyName);
            }
        }

        /// <summary>
        /// Проверяет, является ли переданное значение объектом перечисления.
        /// </summary>
        /// <param name="FlightType"> Переданное значение.</param>
        /// <param name="propertyName">Текст ошибки.</param>
        public static void IsValueInEnum(Model.FlightType FlightType, string propertyName)
        {
            if (!Enum.IsDefined(typeof(Model.FlightType), FlightType))
            {
                throw new ArgumentException(propertyName);
            }
        }
    }
}
