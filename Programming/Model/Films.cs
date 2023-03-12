using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Films
    {
        private String Title;
        private int Duration;
        private int YearOfRelease;
        private String Genre;
        private double Rating;

        public String title
        {
            set 
            {
                Title = value;
            }
            get
            {
                return Title;
            }
        }

        public int duration
        {
            set 
            {
                if (value > 0 && value < 300)
                {
                    Duration = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Duration;
            }
        }

        public int year_of_release
        {
            set
            {
                if (value >= 1900 && value <= 2023)
                {
                    YearOfRelease = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return YearOfRelease;
            }
        }

        public String genre
        {
            set 
            {
                Genre = value;
            }
            get 
            {
                return Genre;
            }
        }

        public double rating
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    Rating = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get 
            {
                return Rating;
            }
        }

        public Films()
        { 
        
        }

        public Films(String Title, int Duration, int YearOfRelease, String Genre, double Rating)
        {
            this.duration = Duration;
            this.title = Title;
            this.year_of_release = YearOfRelease;
            this.genre = Genre;
            this.rating = Rating;
        }

    }
}
