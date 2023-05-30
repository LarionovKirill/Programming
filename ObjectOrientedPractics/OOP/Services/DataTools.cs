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
    public delegate bool CompareValues(Item item, object parameter);

    /// <summary>
    /// Сервисный класс обработки данных товара.
    /// </summary>
    static class DataTools
    {
        /// <summary>
        /// Метод проверяет, что цена товара больше переданного числа.
        /// </summary>
        /// <param name="item">Переденный товар.</param>
        /// <param name="cost">Цена.</param>
        /// <returns>True, если больше, иначе False.</returns>
        public static bool CompareWithCost(Item item, object cost)
        {
            return item.Cost >= (decimal)cost;
        }

        /// <summary>
        /// Метод проверяет, что тип товара совпадает с переданным.
        /// </summary>
        /// <param name="item">Переданный товар.</param>
        /// <param name="category">Категория.</param>
        /// <returns>True, если категория совпадает, иначе False.</returns>
        public static bool CompareWithCategory(Item item, object category)
        {
            return item.ItemCategory == (ItemCategory)category;
        }

        /// <summary>
        /// Метод проверяет наличие подстроки в имени товара.
        /// </summary>
        /// <param name="item">Переданный товар.</param>
        /// <param name="findText">Подстрока.</param>
        /// <returns>True, если есть подстрока, иначе False.</returns>
        public static bool FindItemName(Item item, object findText)
        {
            return item.Name.Contains((string)findText);
        }

        /// <summary>
        /// Метод принимает список товаров и возвращает товары стоимостью более 5000.
        /// </summary>
        /// <param name="items">Исходный список.</param>
        /// <returns>Список с товарами, ценою больше 5000.</returns>
        public static List<Item> FilteringItem(List<Item> items, 
            object parameter, 
            CompareValues compare)
        {
            List<Item> filteringList = new List<Item>();
            foreach(var item in items)
            {
                if (compare(item, parameter))
                {
                    filteringList.Add(item);
                }
            }
            return filteringList;
        }
    }
}
