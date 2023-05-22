using System.Collections.Generic;
using OOP.Model.Enums;

namespace OOP.Model.Discounts
{
    /// <summary>
    /// Класс категорной скидки.
    /// </summary>
    public class PercentDiscount: IDiscount
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
        /// Принимает на вход список продуктов и возвращает размер скидки, доступной для этого
        /// списка продуктов по определенной категории.
        /// </summary>
        /// <param name="items">Список продуктов.</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
    }
}
