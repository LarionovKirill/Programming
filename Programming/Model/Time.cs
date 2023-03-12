using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Time
    {
        private int Hours;
        private int Minutes;
        private int Seconds;

        public int hours
        {
            set
            {
                if (value >= 0 && value <= 23)
                {
                    Hours = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Hours;
            }
        }

        public int minutes
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    Minutes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Minutes;
            }
        }

        public int seconds
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    Seconds = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Seconds;
            }
        }

        public Time()
        {

        }

        public Time(int Hour, int Minute, int Second)
        {
            this.hours = Hour;
            this.minutes = Minute;
            this.seconds = Second;
        }
    }
}
