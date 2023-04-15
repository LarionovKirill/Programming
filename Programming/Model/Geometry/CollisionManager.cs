using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Выполняет проверку о пересечении геометрических фигур.
    /// </summary>
    static class CollisionManager
    {
        /// <summary>
        /// Метод определяет, пересекаются ли прямоугольники или нет.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Если прямоугольники пересекаются, то метод возвращает true,
        /// иначе false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle1.UpperLeftCorner.X < rectangle2.UpperLeftCorner.X + rectangle2.Width &&
                rectangle1.UpperLeftCorner.X + rectangle1.Width > rectangle2.UpperLeftCorner.X &&
                rectangle1.UpperLeftCorner.Y < rectangle2.UpperLeftCorner.Y + rectangle2.Length &&
                rectangle1.UpperLeftCorner.Y + rectangle1.Length > rectangle2.UpperLeftCorner.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод определяет, пересекаются ли круги или нет.
        /// </summary>
        /// <param name="ring1">Первый круг.</param>
        /// <param name="ring2">Второй круг.</param>
        /// <returns>Если кольца пересекаются, то метод возвращает true,
        /// иначе false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double hypotenuse;
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            hypotenuse = Math.Sqrt(dx*dx + dy*dy);
            if (hypotenuse < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            //Проверка на то, что кольцо внутри другого.
            else if (hypotenuse + ring2.OuterRadius < ring1.OuterRadius &&
                hypotenuse - ring2.InnerRadius < ring1.InnerRadius)
            {
                return true;
            }
            //Проверка на то, что кольцо внутри другого.
            else if (hypotenuse + ring1.OuterRadius < ring2.OuterRadius &&
                hypotenuse - ring1.InnerRadius < ring2.InnerRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
