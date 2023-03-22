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
        public string Name 
        { 
            set
            {
                try
                {
                    AssertStringContainsOnlyLetters(value);
                    _name = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set")+4;
                    string error = string.Empty;
                    for (int i = index; i < index + 4; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
                }
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Свойство для поля _surname.
        /// </summary>
        public string Surname 
        {
            set
            {
                try
                {
                    AssertStringContainsOnlyLetters(value);
                    _surname = value;
                }
                catch (Exception ex)
                {
                    int index = ex.StackTrace.IndexOf("set") + 4;
                    string error = string.Empty;
                    for (int i = index; i < index + 7; i++)
                    {
                        error += ex.StackTrace[i];
                    }
                    throw new ArgumentException("Исключение вызвано свойством поля " + error);
                }
            }
            get
            {
                return _surname;
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

        /// <summary>
        /// Проверяет, состоит ли строка только из английских букв.
        /// </summary>
        /// <param name="value">Передаваемая на проверку строка.</param>
        /// <returns></returns>
        private void AssertStringContainsOnlyLetters(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if ((int)'A' > (int)value[i] || (int)'z' < (int)value[i])
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
