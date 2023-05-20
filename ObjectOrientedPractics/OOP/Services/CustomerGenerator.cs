using System.Collections.Generic;
using OOP.Model;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс для создания пользователей.
    /// </summary>
    static class CustomerGenerator
    {
        public static List<Customer> GenerateListOfCustomers()
        {
            List<Customer> _customers = new List<Customer>();
            _customers.Add(new Customer(
                "Иванов Иван Иванович",
                121212,
                "10",
                "Tomsk",
                "Russia",
                "Lenina",
                "12"));
            _customers.Add(new Customer(
                "Петров Петр Павлович",
                321656,
                "85",
                "Novosibirsk",
                "Russia",
                "Fedorova",
                "19"));
            _customers.Add(new Customer(
                "Денисов Михаил Степанович",
                628654,
                "124",
                "Ufa",
                "Russia",
                "Lenina",
                "35"));
            _customers.Add(new Customer(
                "Федосеев Артём Артурович",
                458863,
                "99",
                "Samara",
                "Russia",
                "Cvetochnaya ",
                "36"));
            _customers.Add(new Customer(
                "Головин Вадим Егорович",
                983302,
                "203",
                "Saint Petersburg",
                "Russia",
                "Mohovaya",
                "88"));
            return _customers;
        }
    }
}
