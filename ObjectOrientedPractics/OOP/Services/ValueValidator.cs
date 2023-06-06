using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка, что строка не превышает лимит кол-ва символов.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Свойство, вызвавшое ошибку.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName + $" не может быть длинее {maxLength}");
            }
        }

        /// <summary>
        /// Проверка, что значение не превышает диапазон значений.
        /// </summary>
        /// <param name="value">Передаваемое значение.</param>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <param name="propertyName">Свойство, вызвавшое ошибку.</param>
        public static void AssertValueInRange(decimal  value,
            decimal  minValue, 
            decimal  maxValue, 
            string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException(propertyName + $" может быть от {minValue} " +
                    $"до {maxValue}");
            }
        }

        /// <summary>
        /// Метод проверяет, может ли быть такой почтовый индекс.
        /// </summary>
        /// <param name="index">Передаваемый индекс.</param>
        /// <param name="propertyName">Свойство, вызвавшое метод.</param>
        public static void AssertIndex(int index, string propertyName)
        {
            if (index < 100000 || index >= 1000000)
            {
                throw new ArgumentException(propertyName);
            }
        }

        /// <summary>
        /// Метод проверяет, является ли значение положительным.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Свойство, вызвавшое метод.</param>
        public static void AssertPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(propertyName);
            }
        }
    }
}
