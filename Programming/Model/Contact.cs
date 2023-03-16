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
        private string _surename;

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
        /// Свойство для поля _surename.
        /// </summary>
        public string Surename { get; set;}

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            
        }

        /// <summary>
        /// Констурктор с параметрами.
        /// </summary>
        /// <param name="_number">
        /// Устанавливет значение для поля _number.
        /// </param>
        /// <param name="_name">
        /// Устанавливет значение для поля _name.
        /// </param>
        /// <param name="_surename">
        /// Устанавливет значение для поля _surename.
        /// </param>
        public Contact(int _number, string _name, string _surename)
        {
            this.Name = _name;
            this.Number = _number;
            this.Surename = _surename;
        }
    }
}
