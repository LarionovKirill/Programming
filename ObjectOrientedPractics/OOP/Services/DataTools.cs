using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP.Model;
using OOP.Model.Enums;

namespace OOP.Services
{
    /// <summary>
    /// Делегат, который учавствует в сравнении товара с каким - то его параметром.
    /// </summary>
    /// <param name="item">Переданный товар.</param>
    /// <returns>True, если условия выполняются, иначе False.</returns>
    public delegate bool CompareValues(Item item);

    /// <summary>
    /// Сервисный класс обработки данных товара.
    /// </summary>
    static class DataTools
    {
        /// <summary>
        /// Метод проверяет, что цена товара больше 5000.
        /// </summary>
        /// <param name="item">Переденный товар.</param>
        /// <returns>True, если больше, иначе False.</returns>
        public static bool CompareWithCost(Item item)
        {
            return item.Cost >= 5000;
        }

        /// <summary>
        /// Метод проверяет, что тип товара является "Электроника".
        /// </summary>
        /// <param name="item">Переданный товар.</param>
        /// <returns>True, если категория совпадает, иначе False.</returns>
        public static bool CompareWithCategory(Item item)
        {
            return item.ItemCategory == ItemCategory.Elictronics;
        }


        /// <summary>
        /// Метод принимает список товаров и возвращает товары стоимостью более 5000.
        /// </summary>
        /// <param name="items">Исходный список.</param>
        /// <returns>Список с товарами, ценою больше 5000.</returns>
        public static List<Item> FilteringItem(List<Item> items, CompareValues compare)
        {
            List<Item> filteringList = new List<Item>();
            foreach(var item in items)
            {
                if (compare(item))
                {
                    filteringList.Add(item);
                }
            }
            return filteringList;
        }
    }
}
