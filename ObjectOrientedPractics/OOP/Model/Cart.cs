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
    public class Cart: ICloneable, IEquatable<Cart>
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
        /// Реализация копирования от стандартного интерфейса ICloneable.
        /// </summary>
        /// <returns>Возвращает копию объекта класса <see cref="Cart"/>.</returns>
        public object Clone()
        {
            return new Cart().ListOfGoods = this.ListOfGoods;
        }

        /// <summary>
        /// Перегрузка метода Equals.
        /// </summary>
        /// <param name="other">Сравниваемый объект.</param>
        /// <returns>True, если равны, иначе false.</returns>
        public override bool Equals(object other)
        {
            //Проверка на наличие объекта.
            if (other == null)
            {
                return false;
            }

            //Проверка на один тип.
            if (other.GetType() != typeof(Cart))
            {
                return false;
            }

            //Проверка на одинаковые ссылки.
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            //Проверка каждого элемента в списке.
            var cart2 = (Cart)other;
            if (cart2.ListOfGoods.Count == this.ListOfGoods.Count)
            {
                for (int i = 0; i < this.ListOfGoods.Count; i++)
                {
                    if (cart2.ListOfGoods[i] != this.ListOfGoods[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Перегрузка метода Equals.
        /// </summary>
        /// <param name="other">Сравниваемый объект типа Cart.</param>
        /// <returns>True, если все товары совпадают, иначе False.</returns>
        public bool Equals(Cart other)
        {
            if (other.ListOfGoods.Count == this.ListOfGoods.Count)
            {
                for (int i = 0; i < this.ListOfGoods.Count; i++)
                {
                    if (other.ListOfGoods[i] != this.ListOfGoods[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
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
