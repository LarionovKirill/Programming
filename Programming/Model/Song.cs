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
        private string Author;
        private string Title;
        private double Rating;

        /// <summary>
        /// Свойство для поля Author.
        /// </summary>
        public string author
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

        /// <summary>
        /// Свойство для поля Title.
        /// </summary>
        public string title
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
        public Song()
        {
            
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="Author">Устанавливает значение для поля Author</param>
        /// <param name="Title">Устанавливает значение для поля Title</param>
        /// <param name="Rating">Устанавливает значение для поля Rating</param>
        public Song(string Author, string Title, double Rating)
        {
            this.author = Author;
            this.title = Title;
            this.rating = Rating;
        }
    }
}
