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
        /// Хранит общую стоимость.
        /// </summary>
        private double _fullCost;


        /// <summary>
        /// Свойство id заказа.
        /// </summary>
        public int Id { get; private set; }


        /// <summary>
        /// Свойство даты создания заказа.
        /// </summary>
        public DateTime DateOfCreate { get; private set; }

        /// <summary>
        /// Свойство для списка товаров заказа.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Свойство для адреса доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Свойство для общей стоимости заказа. 
        /// </summary>
        public double FullCost 
        {
            get
            {
                var sum = 0.0d;
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
        public Status OrderStatus { get; set; }


        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Order()
        {
            this.Id = Services.IdGenerator.GetNextOrderID();
        }

        /// <summary>
        /// Конструктор класса заказ.
        /// </summary>
        /// <param name="creatingDate">Дата создания заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="orderStatus">Статус заказа.</param>
        public Order(DateTime creatingDate, Address address, Status orderStatus)
        {
            this.Id = Services.IdGenerator.GetNextOrderID();
            this.DateOfCreate = creatingDate;
            this.Address = address;
            this.OrderStatus = orderStatus;
        }
    }
}
