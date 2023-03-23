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
        /// <summary>
        /// Хранит название фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Хранит продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Хранит год выпуска фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Хранит жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Хранит рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Свойство для поля _title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Свойство для поля _duration.
        /// </summary>
        public int Duration
        {
            set 
            {
                if (value > 0 && value < 300)
                {
                    _duration = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _duration;
            }
        }

        /// <summary>
        /// Свойство для поля _yearOfRelease.
        /// </summary>
        public int YearOfRelease
        {
            set
            {
                if (value >= 1900 && value <= 2023)
                {
                    _yearOfRelease = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _yearOfRelease;
            }
        }

        /// <summary>
        /// Свойство для поля _genre.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Свойство для поля _rating.
        /// </summary>
        public double Rating
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get 
            {
                return _rating;
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
        /// <param name="title">Устанавливет значение для поля _title.</param>
        /// <param name="duration">Устанавливет значение для поля _duration.</param>
        /// <param name="yearOfRelease">Устанавливет значение для поля _yearOfRelease.</param>
        /// <param name="genre">Устанавливет значение для поля _genre.</param>
        /// <param name="rating">Устанавливет значение для поля _rating.</param>
        public Films(string title, int duration, int yearOfRelease, string genre, double rating)
        {
            this.Duration = duration;
            this.Title = title;
            this.YearOfRelease = yearOfRelease;
            this.Genre = genre;
            this.Rating = rating;
        }

    }
}
