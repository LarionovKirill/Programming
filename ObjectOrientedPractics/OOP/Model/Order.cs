using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Order
    {
        /// <summary>
        /// Хранит Id заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Хранит адрес заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Хранит дату создания заказа.
        /// </summary>
        private DateTime _dateOfCreate;

        /// <summary>
        /// Хранит список товаров заказа.
        /// </summary>
        private List<Item> _items;


        /// <summary>
        /// Свойство id заказа.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }


        /// <summary>
        /// Свойство даты создания заказа.
        /// </summary>
        public DateTime DateOfCreate
        {
            get
            {
                return _dateOfCreate;
            }
            private set
            {
                _dateOfCreate = value;
            }
        }

        /// <summary>
        /// Свойство для списка товаров заказа.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Свойство для адреса доставки.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Свойство для общей стоимости заказа. 
        /// </summary>
        public decimal  FullCost 
        {
            get
            {
                var sum = 0.0m;
                if (Items == null || Items.Count == 0)
                {
                    return sum;
                }
                else
                {
                    foreach (var item in Items)
                    {
                        sum += item.Cost;
                    }
                    return sum;
                }
            }
        }

        /// <summary>
        /// Тип заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }


        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Order()
        {
            this.Id = Services.IdGenerator.GetNextOrderID();
            this.Address = new Model.Address();
            this.Items = new List<Model.Item>();
        }

        /// <summary>
        /// Конструктор класса заказ.
        /// </summary>
        /// <param name="creatingDate">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="orderStatus">Статус заказа.</param>
        public Order(DateTime creatingDate, Address address, OrderStatus orderStatus)
        {
            this.Id = Services.IdGenerator.GetNextOrderID();
            this.DateOfCreate = creatingDate;
            this.Address = address;
            this.OrderStatus = orderStatus;
            this.Items = new List<Model.Item>();
        }
    }
}
