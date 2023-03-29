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
            double dx = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dy = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double dWidth = Math.Abs(rectangle1.Width - rectangle2.Width);
            double dLength = Math.Abs(rectangle1.Length - rectangle2.Length);
            if (dx < (dLength / 2) && dy < (dWidth / 2))
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
