using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class RectangleFactory
    {
        static public Rectangle Randomize(int maxWidth, int maxHeight)
        {
            Random random = new Random();
            Rectangle _currentRectangle = new Rectangle();
            _currentRectangle.Length = random.Next(5, 101);
            int heigth = int.Parse(_currentRectangle.Length.ToString());
            _currentRectangle.Width = random.Next(5, 101);
            int width = int.Parse(_currentRectangle.Width.ToString());
            int x = random.Next(15, maxWidth - 15 - width);
            int y = random.Next(15, maxHeight - 15 - heigth);
            Point2D point = new Point2D(x,y);
            _currentRectangle.Center = point;
            return _currentRectangle;
        }
    }
}
