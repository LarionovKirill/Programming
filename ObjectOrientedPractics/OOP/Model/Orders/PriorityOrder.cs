using System;
using OOP.Model.Enums;

namespace OOP.Model.Orders
{
    /// <summary>
    /// Класс хранит приоритетные заказы.
    /// Наследуется от класса
    /// <see cref="Order"></see>
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Свойство времени доставки заказа.
        /// </summary>
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Свойство даты достваки заказа.
        /// </summary>
        public DateTime DeliveryDay { get; set; }

        /// <summary>
        /// Конструктор без параметров, унаследованный от класс <see cref="Order"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            
        }

        /// <summary>
        /// Конструктор класса с параметрами.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="orderStatus">Статус заказа.</param>
        /// <param name="creatingDate">Дата создания заказа.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        /// <param name="deliveryDay">Дата доставки.</param>
        public PriorityOrder(
            Address address,
            OrderStatus orderStatus,
            DateTime creatingDate,
            DeliveryTime deliveryTime, 
            DateTime deliveryDay): base(creatingDate,address, orderStatus)
        {
            this.DeliveryDay = deliveryDay;
            this.DeliveryTime = deliveryTime;
            /*this.Address = address;
            this.DateOfCreate = creatingDate;
            this.OrderStatus = orderStatus;*/
        }

        /// <summary>
        /// Конструктор с параметрами, унаследованный от класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="orderStatus"></param>
        /// <param name="creatingDate"></param>
        public PriorityOrder(
            Address address,
            OrderStatus orderStatus,
            DateTime creatingDate) : base(creatingDate, address, orderStatus)
        {
            
        }
    }
}
