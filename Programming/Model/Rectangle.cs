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
                try
                {
                    Validator checker = new Validator();
                    checker.AssertOnPositiveValue(value);
                    _length = value;
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
                try
                {
                    Validator checker = new Validator();
                    checker.AssertOnPositiveValue(value);
                    _width = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set") + 4;
                    string error = string.Empty;
                    for (int i = index; i < index + 5; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
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
