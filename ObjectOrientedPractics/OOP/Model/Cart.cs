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
    public class Cart
    {
        /// <summary>
        /// Хранит список товаров в корзине.
        /// </summary>
        private List<Item> _listOfGoods;

        /// <summary>
        /// Свойство списка товаров.
        /// </summary>
        public List<Item> ListOfGoods
        {
            get
            {
                return _listOfGoods;
            }
            set
            {
                _listOfGoods = value;
            }
        }

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
    }
}
