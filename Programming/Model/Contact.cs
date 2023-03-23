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
        /// <summary>
        /// Хранит номер человека.
        /// </summary>
        private int _number;

        /// <summary>
        /// Хранит имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит фамилию человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Свойство для поля _number.
        /// </summary>
        public int Number
        {
            set 
            {
                try
                {
                    _number = Convert.ToInt32(value);
                }
                catch 
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return _number;
            }
        }

        /// <summary>
        /// Свойство для поля _name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Свойство для поля _surname.
        /// </summary>
        public string Surname { get; set;}

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            
        }

        /// <summary>
        /// Констурктор с параметрами.
        /// </summary>
        /// <param name="number">
        /// Устанавливет значение для поля _number.
        /// </param>
        /// <param name="name">
        /// Устанавливет значение для поля _name.
        /// </param>
        /// <param name="surname">
        /// Устанавливет значение для поля _surname.
        /// </param>
        public Contact(int number, string name, string surname)
        {
            this.Name = name;
            this.Number = number;
            this.Surname = surname;
        }
    }
}
