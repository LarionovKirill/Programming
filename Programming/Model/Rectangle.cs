using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangle
    {
        private double Length;
        private double Width;
        private String Colour;

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

        public String colour
        {
            set
            {
                Colour = value;
            }
            get
            {
                return Colour;
            }
        }

        public Rectangle()
        { 

        }

        public Rectangle(double Length, double Width,String Colour)
        {
            this.colour = Colour;
            this.length = Length;
            this.width = Width;
        }
    }
}
