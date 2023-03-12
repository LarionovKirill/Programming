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
        private String Subject;
        private int Mark;
        private String Teacher;

        /// <summary>
        /// Свойство для поля Mark.
        /// </summary>
        public int mark
        {
            set
            {
                if (value >= 2 && value <= 5)
                {
                    Mark = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Mark;
            }
        }

        /// <summary>
        /// Свойство для поля Subject.
        /// </summary>
        public String subject
        {
            set 
            {
                Subject = value;
            }
            get
            {
                return Subject;
            }
        }

        /// <summary>
        /// Свойство для поля Teacher.
        /// </summary>
        public String teacher
        {
            set 
            {
                Teacher = value;
            }
            get
            {
                return Teacher;
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
        /// <param name="Subject">
        /// Устанавливет значение для поля Subject.
        /// </param>
        /// <param name="Mark">
        /// Устанавливет значение для поля Mark.
        /// </param>
        /// <param name="Teacher">
        /// Устанавливет значение для поля Teacher.
        /// </param>
        public Discipline(String Subject, int Mark, String Teacher)
        {
            this.mark = Mark;
            this.subject = Subject;
            this.teacher = Teacher;
        }
    }
}
