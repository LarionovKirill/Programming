using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит в себе параметры кольца.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Хранит центр кольца.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Хранит длину меньшего радиуса кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Хранит длину большего радиуса кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Свойство поля _center.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Свойство меньшего радиуса.
        /// </summary>
        public double InnerRadius
        {
            private set 
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                _innerRadius = value;
            }
            get
            {
                return _innerRadius;
            }
        }

        /// <summary>
        /// Свойство для большего радиуса.
        /// </summary>
        public double OuterRadius
        {
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertCorretRadii(InnerRadius, value);
                _outerRadius = value;
            }
            get
            {
                return _outerRadius;
            }
        }

        public double Area
        {
            get 
            {
                double s1;
                double s2;
                s2 = Math.PI * Math.Pow(OuterRadius, 2);
                s1 = Math.PI * Math.Pow(InnerRadius, 2);
                return s2-s1; 
            }
        }

        /// <summary>
        /// Конструтор для класса Ring.
        /// </summary>
        /// <param name="point">Центр кольца.</param>
        /// <param name="radius1">Меньший радиус.</param>
        /// <param name="radius2">Больший радиус.</param>
        public Ring(Point2D point, double radius1, double radius2)
        {
            this.Center = point;
            this.InnerRadius = radius1;
            this.OuterRadius = radius2;
        }
    }
}
