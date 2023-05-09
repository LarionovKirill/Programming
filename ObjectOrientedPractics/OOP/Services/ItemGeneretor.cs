using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс для генерации товара.
    /// </summary>
    static class ItemGeneretor
    {
        /// <summary>
        /// Генерирует простенький список товаров.
        /// </summary>
        /// <returns>Список товаров.</returns>
        public static List<Model.Item> GenerateListOfItems()
        {
            List <Model.Item> _items = new List<Model.Item>();
            _items.Add(new Model.Item("Футболка","Хлопковая",400,Model.Category.Clothes));
            _items.Add(new Model.Item("Шорты", "Трикотажные", 500, Model.Category.Clothes));
            _items.Add(new Model.Item(
                "Наушники", 
                "беспроводные", 
                2000, 
                Model.Category.Elictronics));
            return _items;
        }
    }
}
