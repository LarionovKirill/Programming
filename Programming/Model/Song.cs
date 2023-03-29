using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит описание песни и ее рейтинг.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Хранит автора песни.
        /// </summary>
        private string _author;

        /// <summary>
        /// Хранит название песни.
        /// </summary>
        private string _title;

        /// <summary>
        /// Хранит рейтинг песни. 
        /// </summary>
        private double _rating;

        /// <summary>
        /// Свойство для поля _author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Свойство для поля _title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Свойство для поля _rating.
        /// </summary>
        public double Rating
        {
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
            get
            {
                return _rating;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Song()
        {
            
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="author">Устанавливает значение для поля _author</param>
        /// <param name="title">Устанавливает значение для поля _title</param>
        /// <param name="rating">Устанавливает значение для поля _rating</param>
        public Song(string author, string title, double rating)
        {
            this.Author = author;
            this.Title = title;
            this.Rating = rating;
        }
    }
}
