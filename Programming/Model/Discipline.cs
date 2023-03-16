using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс хранит данные о предмете, оценке и учителе.
    /// </summary>
    class Discipline
    {
        /// <summary>
        /// Хранит название предмета.
        /// </summary>
        private string _subject;

        /// <summary>
        /// Хранит оценку.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Хранит имя учителя.
        /// </summary>
        private string _teacher;

        /// <summary>
        /// Свойство для поля _mark.
        /// </summary>
        public int Mark
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    _mark = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _mark;
            }
        }

        /// <summary>
        /// Свойство для поля _subject.
        /// </summary>
        public string Subject { get; set; }


        /// <summary>
        /// Свойство для поля _teacher.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Discipline()
        {
            
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_subject">
        /// Устанавливет значение для поля _subject.
        /// </param>
        /// <param name="_mark">
        /// Устанавливет значение для поля _mark.
        /// </param>
        /// <param name="_teacher">
        /// Устанавливет значение для поля _teacher.
        /// </param>
        public Discipline(string _subject, int _mark, string _teacher)
        {
            this.Mark = _mark;
            this.Subject = _subject;
            this.Teacher = _teacher;
        }
    }
}
