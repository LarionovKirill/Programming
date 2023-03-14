﻿using System;
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
        private int _number;
        private string _name;
        private string _surename;

        /// <summary>
        /// Свойство для поля _number.
        /// </summary>
        public int number
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
        public string name 
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Свойство для поля _surename.
        /// </summary>
        public string surename 
        {
            set
            {
                _surename = value;
            }
            get
            {
                return _surename;
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
            this.name = _name;
            this.number = _number;
            this.surename = _surename;
        }
    }
}
