using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    /// <summary>
    /// Класс генерирует заказ.
    /// </summary>
    public static class OrderGenerator
    {
        /// <summary>
        /// Класс генерирует случайный заказ.
        /// </summary>
        /// <returns>Готовый заказ.</returns>
        static public Model.PriorityOrder GeneratePriorityOrder()
        {
            var customerList = CustomerGenerator.GenerateListOfCustomers();
            Random random = new Random();
            var randomCustomer = customerList[random.Next(0, customerList.Count)];
            Model.PriorityOrder order = new Model.PriorityOrder(
                randomCustomer.Address,
                (Model.OrderStatus)random.Next(0, 7),
                DateTime.Now,
                (Model.DeliveryTime)random.Next(0, 7),
                DateTime.Now);
            return order;
        }
    }
}
