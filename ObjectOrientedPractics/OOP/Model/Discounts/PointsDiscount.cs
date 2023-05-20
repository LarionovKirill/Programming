using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Хранит баллы пользователя.
        /// </summary>
        private int _points;


        /// <summary>
        /// Свойство баллов пользователя.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                Services.ValueValidator.AssertPositiveValue(value, "Points");
                _points = value;
            }
        }

        /// <summary>
        /// Хранит скидку пользователя.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Принимает на вход список продуктов и возвращает размер скидки, доступной для этого
        /// списка продуктов с текущим количеством баллов
        /// </summary>
        /// <param name="items">Список продуктов.</param>
        /// <returns></returns>
        public decimal Calculate(List<Item> items)
        {
            var sum = 0m;
            foreach (var item in items)
            {
                sum += item.Cost;
            }
            if (Points >= sum * 0.3m)
            {
                return sum * 0.3m;
            }
            else
            {
                return Points;
            }
        }

        /// <summary>
        /// Применяет скидку к тoварам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        public decimal Apply(List<Item> items)
        {
            var sale = Calculate(items);
            this.Points -= (int)sale;
            return sale;
        }

        /// <summary>
        /// Добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            var sum = 0m;
            foreach (var item in items)
            {
                sum += item.Cost;
            }
            Points += (int)(sum * 0.1m);
        }

        /// <summary>
        /// Строковое поле информации о скидке.
        /// Предоставляет информацию в виде: название скидки - кол-во баллов.
        /// </summary>
        public string Info 
        {
            get
            {
                return $"Накопительная - {Points}";
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public PointsDiscount()
        {

        }
    }
}
