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
        public double Length
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
        public double Width
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
        public string Color { get; set; }

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
            this.Color = _color;
            this.Length = _length;
            this.Width = _width;
        }
    }
}
