using System;
using OOP.Model.Orders;
using OOP.Model.Enums;

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
        static public PriorityOrder GeneratePriorityOrder()
        {
            var customerList = CustomerGenerator.GenerateListOfCustomers();
            Random random = new Random();
            var randomCustomer = customerList[random.Next(0, customerList.Count)];
            PriorityOrder order = new PriorityOrder(
                randomCustomer.Address,
                (OrderStatus)random.Next(0, 7),
                DateTime.Now,
                (Model.DeliveryTime)random.Next(0, 7),
                DateTime.Now);
            return order;
        }
    }
}
