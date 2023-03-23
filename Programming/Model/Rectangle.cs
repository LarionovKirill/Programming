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
        /// <summary>
        /// Хранит длину прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Хранит ширину прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Хранит цвет прямоугольника.
        /// </summary>
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
        /// <param name="length">Устанавливает значение для поля _length</param>
        /// <param name="width">Устанавливает значение для поля _width</param>
        /// <param name="color">Устанавливает значение для поля _color</param>
        public Rectangle(double length, double width,string color)
        {
            this.Color = color;
            this.Length = length;
            this.Width = width;
        }
    }
}
