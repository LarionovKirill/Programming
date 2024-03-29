﻿using System;
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
        /// Хранит центр прямоугольника.
        /// </summary>
        private Point2D point;

        /// <summary>
        /// Хранит количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount=0;

        /// <summary>
        /// Хранит id прямоуголников.
        /// </summary>
        private int id; 

        /// <summary>
        /// Свойсвто для поля _length.
        /// </summary>
        public double Length
        {
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
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
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
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
        /// Свойство для поля Center;
        /// </summary>
        public Point2D UpperLeftCorner { get; set; }

        /// <summary>
        /// Свойство для поля _allRectanglesCount
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Свойство поля Id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount += 1;
            this.Id = _allRectanglesCount;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="length">Устанавливает значение для поля _length</param>
        /// <param name="width">Устанавливает значение для поля _width</param>
        /// <param name="color">Устанавливает значение для поля _color</param>
        public Rectangle(double length, double width, string color, Point2D point)
        {
            this.Color = color;
            this.Length = length;
            this.Width = width;
            this.UpperLeftCorner = point;
            _allRectanglesCount += 1;
            this.Id = _allRectanglesCount;
        }
    }
}
