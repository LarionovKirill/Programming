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
		/// Хранит имя пользователя.
		/// </summary>
		private string _fullName;

		/// <summary>
		/// Хранит адрес пользователя.
		/// </summary>
		private string _address;

		/// <summary>
		/// Свойство поля _id.
		/// </summary>
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
		/// Свойство поля _address.
		/// </summary>
		public string Address
		{
			set
			{
				Services.ValueValidator.AssertStringOnLength(
					value,
					500,
					nameof(Address));
				_address = value;
			}
			get
			{
				return _address;
			}
		}
		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Customer()
		{
			this.Id = Services.IdGenerator.GetNextCustomerID();
		}

		/// <summary>
		/// Конструктор класса с параметрами.
		/// </summary>
		/// <param name="fullName"> Имя пользователя.</param>
		/// <param name="address">Адрес пользователя.</param>
		public Customer(string fullName, string address)
		{
			this.Id = Services.IdGenerator.GetNextCustomerID();
			this.FullName = fullName;
			this.Address = address;
		}
	}
}
