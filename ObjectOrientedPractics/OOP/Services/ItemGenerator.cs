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
    static class ItemGenerator
    {
        /// <summary>
        /// Генерирует простенький список товаров.
        /// </summary>
        /// <returns>Список товаров.</returns>
        public static List<Model.Item> GenerateListOfItems()
        {
            List <Model.Item> _items = new List<Model.Item>();
            _items.Add(new Model.Item("Футболка","Хлопковая",400,Model.ItemCategory.Clothes));
            _items.Add(new Model.Item("Шорты", "Трикотажные", 500, Model.ItemCategory.Clothes));
            _items.Add(new Model.Item(
                "Наушники", 
                "беспроводные", 
                2000,
                Model.ItemCategory.Elictronics));
            _items.Add(new Model.Item(
                "Велосипед",
                "21 скорость",
                14000,
                Model.ItemCategory.Sport));
            _items.Add(new Model.Item(
                "PowerBank",
                "10000 mAh",
                1000,
                Model.ItemCategory.Elictronics));
            _items.Add(new Model.Item(
                "Телевизор",
                "4К",
                30000,
                Model.ItemCategory.Elictronics));
            return _items;
        }
    }
}
