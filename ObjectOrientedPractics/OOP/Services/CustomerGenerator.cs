using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static List<string> _names = new List<string>()
        {"Иван","Петр","Михаил","Артём","Вадим","Николай","Евгений","Александр","Данил" };

        /// <summary>
        /// Список фамилий для генерации.
        /// </summary>
        private static List<string> _surnames = new List<string>()
        {"Попов","Петров","Сидоров","Денисов","Головин","Федосеев","Назаров","Лебедев","Фомин" };

        /// <summary>
        /// Список отчеств для генерации.
        /// </summary>
        private static List<string> _patronymic = new List<string>()
        {"Евгеньевич","Кириллович","Андреевич","Владимирович","Егорович","Степанович"};

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Список городов для генерации.
        /// </summary>
        private static List<string> _cities = new List<string>()
        {"Moskow","Tver","Surgut","Tomsk","Novosibirsk","Saratov","Kazan","Ekaterinburg"};

        /// <summary>
        /// Список городов для генерации.
        /// </summary>
        private static List<string> _streets = new List<string>()
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
                    $"{_surnames[_random.Next(0, 9)]} {_names[_random.Next(0, 9)]} " +
                    $"{_patronymic[_random.Next(0, 6)]}",
                    _random.Next(100000, 1000000),
                    _random.Next(1, 200).ToString(),
                    _cities[_random.Next(0, 8)].ToString(),
                    "Russia",
                    _streets[_random.Next(0, 8)].ToString(),
                    _random.Next(1, 200).ToString()));
            }
            return customers;
        }
    }
}
