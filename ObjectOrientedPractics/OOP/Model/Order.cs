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
        /// Свойство id заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство даты создания заказа.
        /// </summary>
        public DateTime DateOfCreate { get; set; }

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
