using System;
using System.Collections.Generic;
using OOP.Model;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс для генерации товара.
    /// </summary>
    static class ItemGenerator
    {
        /// <summary>
        /// Список имен для генерации.
        /// </summary>
        private static string[] GOODS =
        {"Консоль","Телефон","Наушники","Пылесос","Монитор","Плеер","PowerBank","Клавиатура" };

        /// <summary>
        /// Список фамилий для генерации.
        /// </summary>
        private static string[] INFO = 
        {"2023г выпуска","2022г выпуска","2021г выпуска","2020г выпуска"};

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random RANDOM = new Random();

        /// <summary>
        /// Генерирует список товаров.
        /// </summary>
        /// <returns>Список товаров.</returns>
        public static List<Model.Item> GenerateListOfItems()
        {
            List <Model.Item> items = new List<Model.Item>();
            for (int i = 0; i < 8; i++)
            {
                items.Add(new Item(
                    GOODS[RANDOM.Next(8)],
                    INFO[RANDOM.Next(4)],
                    RANDOM.Next(500,30000),
                    ItemCategory.Elictronics));
            }
            return items;
        }
    }
}
