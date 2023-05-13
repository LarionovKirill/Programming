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
        /// Свойство списка _items.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Свойство списка _customers.
        /// </summary>
        public List<Customer> Customers { get; set; }

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
