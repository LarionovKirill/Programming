using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Описывает корзину товаров.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Свойство списка товаров.
        /// </summary>
        public List<Item> ListOfGoods { get; set; }

        /// <summary>
        /// Свойство подсчета стоимости.
        /// </summary>
        public decimal  Amount
        {
            get
            {
                var sum = 0.0m;
                if (ListOfGoods == null || ListOfGoods.Count == 0)
                    return sum;
                else
                {
                    foreach (var item in ListOfGoods)
                    {
                        sum += item.Cost;
                    }
                    return sum;
                }
            }
        }

        /// <summary>
        /// Конструктор класса корзины.
        /// </summary>
        public Cart()
        {
            ListOfGoods = new List<Item>();
        }

        /// <summary>
        /// Реализация копирования от стандартного интерфейса ICloneable.
        /// </summary>
        /// <returns>Возвращает копию объекта класса <see cref="Cart"/>.</returns>
        public object Clone()
        {
            Cart cloneCart = new Cart();
            cloneCart.ListOfGoods = this.ListOfGoods;
            return cloneCart;
        }
    }
}
