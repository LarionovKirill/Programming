using System;
using System.Collections.Generic;

namespace OOP.Model
{
    /// <summary>
    /// Интерфейс скидки.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Метод выдает строковое значение названия скидки и ее кол-во. 
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Метод считает скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        decimal Calculate(List<Item> items);

        /// <summary>
        /// Метод применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        decimal Apply(List<Item> items);

        /// <summary>
        /// Метод обновляет значение скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);

    }
}
