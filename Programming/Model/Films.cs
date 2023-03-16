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
        private string _title;
        private int _duration;
        private int _yearOfRelease;
        private string _genre;
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
        /// <param name="_title">Устанавливет значение для поля _title.</param>
        /// <param name="_duration">Устанавливет значение для поля _duration.</param>
        /// <param name="_yearOfRelease">Устанавливет значение для поля _yearOfRelease.</param>
        /// <param name="_genre">Устанавливет значение для поля _genre.</param>
        /// <param name="_rating">Устанавливет значение для поля _rating.</param>
        public Films(string _title, int _duration, int _yearOfRelease, string _genre, double _rating)
        {
            this.Duration = _duration;
            this.Title = _title;
            this.YearOfRelease = _yearOfRelease;
            this.Genre = _genre;
            this.Rating = _rating;
        }

    }
}
