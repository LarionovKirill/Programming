using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс хранит в себе поля: номер, имя, фамилия.
    /// </summary>
    class Contact
    {
        private int Number;
        private string Name;
        private string Surename;

        /// <summary>
        /// Свойство для поля Number.
        /// </summary>
        public int number
        {
            set 
            {
                try
                {
                    Number = Convert.ToInt32(value);
                }
                catch 
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return Number;
            }
        }

        /// <summary>
        /// Свойство для поля Name.
        /// </summary>
        public string name 
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }

        /// <summary>
        /// Свойство для поля Surename.
        /// </summary>
        public string surename 
        {
            set
            {
                Surename = value;
            }
            get
            {
                return Surename;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            
        }

        /// <summary>
        /// Констурктор с параметрами.
        /// </summary>
        /// <param name="Number">
        /// Устанавливет значение для поля Number.
        /// </param>
        /// <param name="Name">
        /// Устанавливет значение для поля Name.
        /// </param>
        /// <param name="Surename">
        /// Устанавливет значение для поля Surename.
        /// </param>
        public Contact(int Number, string Name, string Surename)
        {
            this.name = Name;
            this.number = Number;
            this.surename = Surename;
        }
    }
}
