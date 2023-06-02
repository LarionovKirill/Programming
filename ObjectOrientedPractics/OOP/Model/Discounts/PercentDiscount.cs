using System;
using System.Collections.Generic;
using OOP.Model.Enums;

namespace OOP.Model.Discounts
{
    /// <summary>
    /// Класс категорной скидки.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Текущая скидка.
        /// </summary>
        private int _currentDiscount = 1;

        /// <summary>
        /// Потраченная сумма.
        /// </summary>
        private decimal _amountSpent;

        /// <summary>
        /// Свойство текущей скидки.
        /// </summary>
        public int CurrentDiscount
        {
            get
            {
                return _currentDiscount;
            }
            set
            {
                _currentDiscount = value;
            }
        }

        /// <summary>
        /// Свойство потраченной суммы.
        /// </summary>
        public decimal AmountSpent
        {
            get
            {
                return _amountSpent;
            }
            set
            {
                _amountSpent = value;
            }
        }

        /// <summary>
        /// Свойство категория товара.
        /// </summary>
        public ItemCategory DiscountItemCategory { get; set; }

        /// <summary>
        /// Строковое поле информации о скидке.
        /// Предоставляет информацию в виде: название скидки - кол-во баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{DiscountItemCategory}» - {CurrentDiscount}%";
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public PercentDiscount()
        {

        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="discountCategory">Категория скидочных товаров.</param>
        public PercentDiscount(ItemCategory discountCategory)
        {
            this.DiscountItemCategory = discountCategory;
        }

        /// <summary>
		/// Реализует сравнение классов <see cref="PercentDiscount"/> по размеру скидки.
		/// </summary>
		/// <param name="other">Сравниваемый объект.</param>
		/// <returns>Метод должен возвращать 0, если скидки равны; 1, если скидка исходного объекта
		/// больше передаваемого в метод; и -1, если скидка исходного объекта меньше 
		/// передаваемого в метод.
		/// </returns>
        public int CompareTo(PercentDiscount other)
        {
            if (this.CurrentDiscount == other.CurrentDiscount)
            {
                return 0;
            }
            else if (this.CurrentDiscount < other.CurrentDiscount)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Принимает на вход список продуктов и возвращает размер скидки, доступной для этого
        /// списка продуктов по определенной категории.
        /// </summary>
        /// <param name="items">Список продуктов.</param>
        /// <returns>Размер скидки на выбранный тип товара.</returns>
        public decimal Calculate(List<Item> items)
        {
            var sum = 0m;
            foreach (var item in items)
            {
                if (item.ItemCategory == DiscountItemCategory)
                {
                    sum += item.Cost;
                }
            }
            return sum * _currentDiscount / 100;
        }

        /// <summary>
        /// Применяет скидку к тoварам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает скидку на тип товара.</returns>
        public decimal Apply(List<Item> items)
        {
            var sale = Calculate(items);
            return sale;
        }

        /// <summary>
        /// Изменяет скидку на основе потраченных денег.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            var sum = 0m;
            var sale = Apply(items);
            foreach (var item in items)
            {
                if (item.ItemCategory == DiscountItemCategory)
                {
                    sum += item.Cost;
                }
            }
            sum -= sale;
            AmountSpent += sum;
            if ((int)AmountSpent / 1000 >= 11)
            {
                CurrentDiscount = 10;
            }
            else
            {
                CurrentDiscount = ((int)AmountSpent / 1000) + 1;
            }
        }
    }
}
