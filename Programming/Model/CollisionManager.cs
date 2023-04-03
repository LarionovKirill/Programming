﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
            int dx = int.Parse((rectangle1.Center.X + rectangle1.Width).ToString());
            int dx2 = int.Parse((rectangle2.Center.X + rectangle2.Width).ToString());
            int dy = int.Parse((rectangle1.Center.Y + rectangle1.Length).ToString());
            int dy2 = int.Parse((rectangle2.Center.Y + rectangle2.Length).ToString());
            Point rectangle1Next = new Point(dx,dy);
            Point rectangle2Next = new Point(dx2,dy2);
            if (rectangle2Next.X < rectangle1.Center.X || rectangle1Next.X < rectangle2.Center.X)
            {
                return false;
            }
            else 
            {
                if (rectangle1Next.Y < rectangle2.Center.Y || rectangle1.Center.Y > rectangle2Next.Y)
                {
                    return false;
                }
                else
                {
                    return true;
                }
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