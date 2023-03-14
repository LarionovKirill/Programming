using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит описание прямоугольника.
    /// </summary>
    class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        /// <summary>
        /// Свойсвто для поля _length.
        /// </summary>
        public double length
        {
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _length;
            }
        }

        /// <summary>
        /// Свойство для поля _width.
        /// </summary>
        public double width
        {
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Свойство для поля _color.
        /// </summary>
        public string color
        {
            set
            {
                _color = value;
            }
            get
            {
                return _color;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Rectangle()
        { 

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_length">Устанавливает значение для поля _length</param>
        /// <param name="_width">Устанавливает значение для поля _width</param>
        /// <param name="_color">Устанавливает значение для поля _color</param>
        public Rectangle(double _length, double _width,string _color)
        {
            this.color = _color;
            this.length = _length;
            this.width = _width;
        }
    }
}
