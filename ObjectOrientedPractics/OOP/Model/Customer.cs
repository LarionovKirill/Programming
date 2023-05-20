using System;
using System.Collections.Generic;
using System.ComponentModel;
using OOP.Model.Discounts;
using OOP.Model.Orders;


namespace OOP.Model
{
	/// <summary>
	/// Класс хранит пользователя
	/// </summary>
	[Serializable]
	public class Customer
	{
		/// <summary>
		/// Хранит имя пользователя.
		/// </summary>
		private string _fullName;

		/// <summary>
		/// Свойство поля _id.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Id { get; private set; }

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
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Address Address { get; set; }

		/// <summary>
		/// Свойство для корзины.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Cart Cart { get; set; }

		/// <summary>
		/// Свойство для списка заказов.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public List<Order> Orders { get; set; }

		/// <summary>
		/// Свойство хранящее показатель приоритетного заказа.
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool IsPriority { get; set; } = false;
		/// Копирует информацию в переданный класс.
		/// </summary>
		/// <param name="customer">Класс, в котором нужно поменять информацию.</param>
		public void CopyInformation(Customer customer)
		{
			customer.Address.Apartment = this.Address.Apartment;
			customer.Address.Building = this.Address.Building;
			customer.Address.City = this.Address.City;
			customer.Address.Country = this.Address.Country;
			customer.Address.Index = this.Address.Index;
			customer.Address.Street = this.Address.Street;
			customer.Cart = this.Cart;
			customer.FullName = this.FullName;
			customer.Orders = this.Orders;
			customer.Id = this.Id;
		}

		/// <summary>
		/// Хранит список скидок пользователя.
		/// </summary>
		public List<IDiscount> Discounts { get; set; }

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Customer()
		{
			Address = new Address();
			this.Cart = new Cart();
			this.Orders = new List<Order>();
			this.Discounts = new List<IDiscount>();
			this.Discounts.Add(new PointsDiscount());
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
			this.Discounts = new List<IDiscount>();
			this.Discounts.Add(new PointsDiscount());
		}
	}
}
