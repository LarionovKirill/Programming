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
        private string _subject;
        private int _mark;
        private string _teacher;

        /// <summary>
        /// Свойство для поля _mark.
        /// </summary>
        public int mark
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
        public string subject
        {
            set 
            {
                _subject = value;
            }
            get
            {
                return _subject;
            }
        }

        /// <summary>
        /// Свойство для поля _teacher.
        /// </summary>
        public string teacher
        {
            set 
            {
                _teacher = value;
            }
            get
            {
                return _teacher;
            }
        }

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
            this.mark = _mark;
            this.subject = _subject;
            this.teacher = _teacher;
        }
    }
}
