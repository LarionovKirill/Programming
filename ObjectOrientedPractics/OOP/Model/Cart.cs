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
    [Serializable]
    public class Cart
    {
        /// <summary>
        /// Свойство списка товаров.
        /// </summary>
        public List<Item> ListOfGoods { get; set; }

        /// <summary>
        /// Свойство подсчета стоимости.
        /// </summary>
        public double Amount
        {
            get
            {
                var sum = 0.0d;
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
    }
}
