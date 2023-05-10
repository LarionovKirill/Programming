using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
	/// <summary>
	/// Класс хранит пользователя
	/// </summary>
	[Serializable]
	public class Customer
	{
		/// <summary>
		/// Хранит Id пользователя.
		/// </summary>
		private int _id;

		/// <summary>
		/// Хранит имя пользователя.
		/// </summary>
		private string _fullName;

		/// <summary>
		/// Хранит адрес доставки.
		/// </summary>
		private Address _address;

		/// <summary>
		/// Свойство поля _id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Хранит корзину пользователя.
		/// </summary>
		private Cart _cart;

		/// <summary>
		/// Список заказов пользователя.
		/// </summary>
		private List<Order> _orders;

		/// <summary>
		/// Свойство поля _fullName.
		/// </summary>
		public string FullName
		{
			set
			{
				Services.ValueValidator.AssertStringOnLength(
					value,
					200,
					nameof(FullName));
				_fullName = value;
			}
			get
			{
				return _fullName;
			}
		}
		/// <summary>
		/// Свойство для адреса доставки.
		/// </summary>
		public Address Address {
			get 
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}

		/// <summary>
		/// Свойство для корзины.
		/// </summary>
		public Cart Cart
		{
			get
			{
				return _cart;
			}
			set
			{
				_cart = value;
			}
		}

		/// <summary>
		/// Свойство для списка заказов.
		/// </summary>
		public List<Order> Orders 
		{
			get
			{
				return _orders;
			}
			set
			{
				_orders = value;
			} 
		}

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Customer()
		{
			this.Id = Services.IdGenerator.GetNextCustomerID();
			Address = new Address();
			this.Cart = new Cart();
			this.Orders = new List<Order>();
		}


		/// <summary>
		/// Конструктор класса с параметрами.
		/// </summary>
		/// <param name="fullName">Имя пользователя.</param>
		/// <param name="Postindex">Почтовый индекс.</param>
		/// <param name="building">Номер дома.</param>
		/// <param name="city">Город.</param>
		/// <param name="country">Страна.</param>
		/// <param name="street">Улица.</param>
		/// <param name="apartment">Квартира.</param>
		public Customer(
			string fullName,
			int Postindex,
			string building,
			string city,
			string country,
			string street,
			string apartment)
		{
			this.Id = Services.IdGenerator.GetNextCustomerID();
			this.FullName = fullName;
			this.Address = new Address(Postindex, country, city, street, building, apartment);
			this.Cart = new Cart();
			this.Orders = new List<Order>();
		}
	}
}
