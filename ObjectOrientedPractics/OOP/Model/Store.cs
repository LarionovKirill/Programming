using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Класс магазина, который хранит товары и пользователей.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Списое товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список пользователей.
        /// </summary>
        private List<Customer> _customres;

        /// <summary>
        /// Свойство списка _items.
        /// </summary>
        public List<Item> Items
        {
            set
            {
                _items = value;
            }
            get
            {
                return _items;
            }
        }

        /// <summary>
        /// Свойство списка _customers.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customres;
            }
            set
            {
                _customres = value;
            }
        }

        /// <summary>
        /// Конструктор класса Store без параметров.
        /// </summary>
        public Store()
        {
            this.Items = new List<Item>();
            this.Customers = new List<Customer>();
        }
    }
}
