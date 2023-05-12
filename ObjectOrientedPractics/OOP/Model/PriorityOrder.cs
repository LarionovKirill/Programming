using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Класс хранит приоритетные заказы.
    /// Наследуется от класса
    /// <see cref="Order"></see>
    /// </summary>
    class PriorityOrder : Order
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
        /// Конструктор без параметров, унаследованный от родительского класса.
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

    }
}
