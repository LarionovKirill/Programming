using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        private String Author;
        private String Title;
        private double Rating;

        public String author
        {
            set
            {
                Author = value;
            }
            get
            {
                return Author;
            }
        }

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

        public Song()
        {
            
        }

        public Song(String Author, String Title, double Rating)
        {
            this.author = Author;
            this.title = Title;
            this.rating = Rating;
        }
    }
}
