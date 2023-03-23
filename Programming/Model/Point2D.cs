using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит координаты точки в двухмерном пространстве.
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Хранит координату X.
        /// </summary>
        private double _x;

        /// <summary>
        /// Хранит координату Y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Свойство поля _X.
        /// </summary>
        public double X
        {
            private set
            {
                Validator validator = new Validator();
                validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Свойство поля _y.
        /// </summary>
        public double Y
        {
            private set
            {
                Validator validator = new Validator();
                validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Конструктор класса Point2D.
        /// </summary>
        /// <param name="x">Значение координаты X.</param>
        /// <param name="y">Значение координаты Y.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }


    }
}
