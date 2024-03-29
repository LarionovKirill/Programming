﻿using System;
using System.Collections.Generic;

namespace OOP.Model.Discounts
{
    /// <summary>
    /// Класс накопительной скидки (Хранит баллы пользователя). 
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
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
        /// Конструктор без параметров.
        /// </summary>
        public PointsDiscount()
        {

        }

        /// <summary>
        /// Принимает на вход список продуктов и возвращает размер скидки, доступной для этого
        /// списка продуктов с текущим количеством баллов.
        /// </summary>
        /// <param name="items">Список продуктов.</param>
        /// <returns>Возвращает скидку на товар учитывая количество баллов у пользователя.</returns>
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
        /// <returns>Считает скидку и списывает баллы у пользователя.</returns>
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
            sum -= Discount;
            Points += (int)(sum * 0.1m);
        }

        /// <summary>
        /// Реализует сравнение классов <see cref="PointsDiscount"/> по количеству баллов.
        /// </summary>
        /// <param name="other">Сравниваемый объект.</param>
        /// <returns>Метод должен возвращать 0, если баллы равны; 1, если баллы исходного объекта
        /// больше передаваемого в метод; и -1, если баллы исходного объекта меньше 
        /// передаваемого в метод.
        /// </returns>
        public int CompareTo(PointsDiscount other)
        {
            if (this.Points == other.Points)
            {
                return 0;
            }
            else if (this.Points < other.Points)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Строковое поле информации о скидке.
        /// Предоставляет информацию в виде: название скидки - кол-во баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} балл(ов)";
            }
        }
    }
}
