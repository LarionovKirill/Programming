using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class RectangleFactory
    {
        /// <summary>
        /// Создает случайный прямоугольник, который не выйжет за пределы канвы. 
        /// </summary>
        /// <param name="maxWidth"> Максимальная ширина канвы.</param>
        /// <param name="maxHeight">Максимальная выстока канвы.</param>
        /// <returns>Возвращает сгенерированный прямоугольник.</returns>
        static public Rectangle Randomize(int maxWidth, int maxHeight)
        {
            Random random = new Random();
            Rectangle currentRectangle = new Rectangle();
            currentRectangle.Length = random.Next(5, 101);
            int heigth = int.Parse(currentRectangle.Length.ToString());
            currentRectangle.Width = random.Next(5, 101);
            int width = int.Parse(currentRectangle.Width.ToString());
            int x = random.Next(15, maxWidth - 15 - width);
            int y = random.Next(15, maxHeight - 15 - heigth);
            Point2D point = new Point2D(x,y);
            currentRectangle.Center = point;
            return currentRectangle;
        }
    }
}
