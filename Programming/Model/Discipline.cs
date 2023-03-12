using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Discipline
    {
        private String Subject;
        private int Mark;
        private String Teacher;

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

        public Discipline()
        {
            
        }

        public Discipline(String Subject, int Mark, String Teacher)
        {
            this.mark = Mark;
            this.subject = Subject;
            this.teacher = Teacher;
        }
    }
}
