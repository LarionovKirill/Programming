using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP.Model;

namespace OOP.Services
{
    static class DataTools
    {
        /// <summary>
        /// Метод принимает список товаров и возвращает товары стоимостью более 5000.
        /// </summary>
        /// <param name="items">Исходный список.</param>
        /// <returns>Список с товарами, ценою больше 5000.</returns>
        static List<Item> FilteringProducts(List<Item> items)
        {
            List<Item> filteringList = new List<Item>();
            foreach(var item in items)
            {
                if (item.Cost >= 5000)
                {
                    filteringList.Add(item);
                }
            }
            return filteringList;
        }
    }
}
