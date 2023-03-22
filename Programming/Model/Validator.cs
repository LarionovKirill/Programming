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
        public void AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Проверяет, что дробное число больше нуля.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        public void AssertOnPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
