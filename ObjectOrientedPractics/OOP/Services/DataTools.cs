using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP.Model;
using OOP.Model.Enums;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс обработки данных товара.
    /// </summary>
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

        /// <summary>
        /// Метод принимает список товаров с ворзвращает список товаров определенной категории.
        /// </summary>
        /// <param name="items">Исходный список.</param>
        /// <returns>Список товаров выбранной категории.</returns>
        static List<Item> FilteringByCategory(List<Item> items)
        {
            var choosenCategory = ItemCategory.Elictronics;
            List<Item> filteringList = new List<Item>();
            foreach (var item in items)
            {
                if (item.ItemCategory == choosenCategory)
                {
                    filteringList.Add(item);
                }
            }
            return filteringList;
        }
    }
}
