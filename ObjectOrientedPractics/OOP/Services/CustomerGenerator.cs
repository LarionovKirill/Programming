using System;
using System.Collections.Generic;
using OOP.Model;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс для создания пользователей.
    /// </summary>
    static class CustomerGenerator
    {
        /// <summary>
        /// Список имен для генерации.
        /// </summary>
        private static List<string> NAMES = new List<string>()
        {"Иван","Петр","Михаил","Артём","Вадим","Николай","Евгений","Александр","Данил" };

        /// <summary>
        /// Список фамилий для генерации.
        /// </summary>
        private static List<string> SURNAMES = new List<string>()
        {"Попов","Петров","Сидоров","Денисов","Головин","Федосеев","Назаров","Лебедев","Фомин" };

        /// <summary>
        /// Список отчеств для генерации.
        /// </summary>
        private static List<string> PATRONYMIC = new List<string>()
        {"Евгеньевич","Кириллович","Андреевич","Владимирович","Егорович","Степанович"};

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random RANDOM = new Random();

        /// <summary>
        /// Список городов для генерации.
        /// </summary>
        private static List<string> CITIES = new List<string>()
        {"Moskow","Tver","Surgut","Tomsk","Novosibirsk","Saratov","Kazan","Ekaterinburg"};

        /// <summary>
        /// Список городов для генерации.
        /// </summary>
        private static List<string> STREETS = new List<string>()
        {"Lenina","Gogola","Fedorova","Cvetochnaya","Mohovaya","Svetlaya","Azina","Nosova"};


        /// <summary>
        /// Генератор случайных пользователей.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public static List<Model.Customer> GenerateListOfCustomers()
        {
            List<Model.Customer> customers = new List<Model.Customer>();
            for (int i = 0; i < 5; i++)
            {
                customers.Add(new Model.Customer(
                    $"{SURNAMES[RANDOM.Next(0, 9)]} {NAMES[RANDOM.Next(0, 9)]} " +
                    $"{PATRONYMIC[RANDOM.Next(0, 6)]}",
                    RANDOM.Next(100000, 1000000),
                    RANDOM.Next(1, 200).ToString(),
                    CITIES[RANDOM.Next(0, 8)].ToString(),
                    "Russia",
                    STREETS[RANDOM.Next(0, 8)].ToString(),
                    RANDOM.Next(1, 200).ToString()));
            }
            return customers;
        }
    }
}
