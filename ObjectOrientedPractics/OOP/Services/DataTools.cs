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
    public static class DataTools
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
        /// Метод сравнивает 2 товара по цене.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>True, если первый больше.</returns>
        public static bool CompareAscending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        /// <summary>
        /// Метод сравнивает 2 товара по цене.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>True, если второй больше.</returns>
        public static bool CompareDescending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Метод сравнивает 2 товара по имени.
        /// Для сортировки по лексикографическому правилу.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>True, если второй товар должен стоять раньше по лексикографическому правилу.</returns>
        public static bool CompareName(Item item1, Item item2)
        {
            if (string.Compare(item1.Name, item2.Name) < 0)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }

        /// <summary>
        /// Метод принимает список товаров и возвращает товары стоимостью более 5000.
        /// </summary>
        /// <param name="items">Исходный список.</param>
        /// <returns>Список с товарами, ценою больше 5000.</returns>
        public static List<Item> FilteringItem(
            List<Item> items, 
            object parameter,
            Func<Item, object, bool> compare)
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

        /// <summary>
        /// Метод сортирует товары по определенному делегату.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="compare">Делегат сортировки.</param>
        /// <returns>Отсортированный список.</returns>
        public static List<Item> SortItems(List<Item> items, Func<Item, Item, bool> compare)
        {
            if (items != null && compare != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    for (int j = 0; j < items.Count - 1 - i; j++)
                    {
                        if (compare(items[j], items[j + 1]))
                        {
                            var tempItem = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = tempItem;
                        }
                    }
                }
                return items;
            }
            else
            {
                return new List<Item>();
            }
        }
    }
}
