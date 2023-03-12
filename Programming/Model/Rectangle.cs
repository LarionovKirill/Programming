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
        private double Length;
        private double Width;
        private String Color;

        /// <summary>
        /// Свойсвто для поля Length.
        /// </summary>
        public double length
        {
            set
            {
                if (value > 0)
                {
                    Length = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Length;
            }
        }

        /// <summary>
        /// Свойство для поля Width.
        /// </summary>
        public double width
        {
            set
            {
                if (value > 0)
                {
                    Width = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Width;
            }
        }

        /// <summary>
        /// Свойство для поля Color.
        /// </summary>
        public String color
        {
            set
            {
                Color = value;
            }
            get
            {
                return Color;
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
        /// <param name="Length">Устанавливает значение для поля Length</param>
        /// <param name="Width">Устанавливает значение для поля Width</param>
        /// <param name="Color">Устанавливает значение для поля Color</param>
        public Rectangle(double Length, double Width,String Color)
        {
            this.color = Color;
            this.length = Length;
            this.width = Width;
        }
    }
}
