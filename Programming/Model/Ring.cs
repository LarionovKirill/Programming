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
        private double _radius1;

        /// <summary>
        /// Хранит длину большего радиуса кольца.
        /// </summary>
        private double _radius2;

        /// <summary>
        /// Свойство поля _center.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Свойство меньшего радиуса.
        /// </summary>
        public double Radius1
        {
            private set 
            {
                Validator validator = new Validator();
                validator.AssertOnPositiveValue(value, nameof(Radius1));
                _radius1 = value;
            }
            get
            {
                return _radius1;
            }
        }

        /// <summary>
        /// Свойство для большего радиуса.
        /// </summary>
        public double Radius2
        {
            set 
            {
                Validator validator = new Validator();
                validator.AssertOnPositiveValue(value, nameof(Radius2));
                validator.AssertCorretRadii(Radius1, value);
                _radius2 = value;
            }
            get
            {
                return _radius2;
            }
        }

        public double Area
        {
            get 
            {
                double s1;
                double s2;
                s2 = Math.PI * Math.Pow(Radius2, 2);
                s1 = Math.PI * Math.Pow(Radius1, 2);
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
            this.Radius1 = radius1;
            this.Radius2 = radius2;
        }
    }
}
