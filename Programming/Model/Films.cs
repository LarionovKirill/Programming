using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме и его параметрах.
    /// </summary>
    class Films
    {
        private String Title;
        private int Duration;
        private int YearOfRelease;
        private String Genre;
        private double Rating;

        /// <summary>
        /// Свойство для поля Title.
        /// </summary>
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

        /// <summary>
        /// Свойство для поля Duration.
        /// </summary>
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

        /// <summary>
        /// Свойство для поля YearOfRelease.
        /// </summary>
        public int yearOfRelease
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

        /// <summary>
        /// Свойство для поля Genre.
        /// </summary>
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

        /// <summary>
        /// Свойство для поля Rating.
        /// </summary>
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

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Films()
        { 
        
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="Title">Устанавливет значение для поля Title.</param>
        /// <param name="Duration">Устанавливет значение для поля Duration.</param>
        /// <param name="YearOfRelease">Устанавливет значение для поля YearOfRelease.</param>
        /// <param name="Genre">Устанавливет значение для поля Genre.</param>
        /// <param name="Rating">Устанавливет значение для поля Rating.</param>
        public Films(String Title, int Duration, int YearOfRelease, String Genre, double Rating)
        {
            this.duration = Duration;
            this.title = Title;
            this.yearOfRelease = YearOfRelease;
            this.genre = Genre;
            this.rating = Rating;
        }

    }
}
