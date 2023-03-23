using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Validator
    {
        /// <summary>
        /// Проверяет, что целое число больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        public void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException("Поле " + propertyName + " должно быть неотрицательным");
            }
        }

        /// <summary>
        /// Проверяет, что дробное число больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        public void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException("Поле " + propertyName + " должно быть неотрицательным");
            }
        }

        /// <summary>
        /// Проверяет, соответствует ли введенное значение диапазону.
        /// </summary>
        /// <param name="value">Введенное значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        public void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Поле " + propertyName + " должно быть в диапазоне " +
                    "от "+ min.ToString() + " до " + max.ToString());
            }
        }

        /// <summary>
        /// Проверяет, соответствует ли введенное значение диапазону.
        /// </summary>
        /// <param name="value">Введенное значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        public void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Поле " + propertyName + " должно быть в диапазоне " +
                    "от " + min.ToString() + " до " + max.ToString());
            }
        }
    }
}
