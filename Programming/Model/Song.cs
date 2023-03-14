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
        private string _author;
        private string _title;
        private double _rating;

        /// <summary>
        /// Свойство для поля _author.
        /// </summary>
        public string author
        {
            set
            {
                _author = value;
            }
            get
            {
                return _author;
            }
        }

        /// <summary>
        /// Свойство для поля _title.
        /// </summary>
        public string title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        /// <summary>
        /// Свойство для поля _rating.
        /// </summary>
        public double rating
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
        public Song()
        {
            
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="_author">Устанавливает значение для поля _author</param>
        /// <param name="_title">Устанавливает значение для поля _title</param>
        /// <param name="_rating">Устанавливает значение для поля _rating</param>
        public Song(string _author, string _title, double _rating)
        {
            this.author = _author;
            this.title = _title;
            this.rating = _rating;
        }
    }
}
