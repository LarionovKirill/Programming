using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
	/// <summary>
	/// Класс товар.
	/// </summary>
	public class Item
	{

		/// <summary>
		/// Название товара.
		/// </summary>
		private string _name;

		/// <summary>
		/// Описание товара.
		/// </summary>
		private string _info;

		/// <summary>
		/// Цена товара.
		/// </summary>
		private decimal _cost;

		/// <summary>
		/// Свойство для поля _id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Свойство для поля _name.
		/// </summary>
		public string Name
		{
			set
			{
				Services.ValueValidator.AssertStringOnLength(
					value,
					200,
					nameof(Name));
				_name = value;
			}
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// Свойство для поля _info.
		/// </summary>
		public string Info
		{
			set
			{
				Services.ValueValidator.AssertStringOnLength(
						value,
						1000,
						nameof(Info));
				_info = value;
			}
			get
			{
				return _info;
			}
		}

		/// <summary>
		/// Свойство для поля _cost.
		/// </summary>
		public decimal Cost
		{
			set
			{
				Services.ValueValidator.AssertValueInRange(
					value,
					0,
					100000,
					nameof(Cost));
				_cost = value;
			}
			get
			{
				return _cost;
			}
		}

		/// <summary>
		/// Свойство категории товаров.
		/// </summary>
		public Category Category { get; set; }

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Item()
		{
			this.Id = Services.IdGenerator.GetNextItemID();
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="name">Имя товара.</param>
		/// <param name="info">Информация о товаре.</param>
		/// <param name="cost">Цена товара.</param>
		/// <param name="category">Категория товара.</param>
		public Item(string name, string info, decimal cost)
		{
			this.Info = info;
			this.Name = name;
			this.Cost = cost;
			this.Id = Services.IdGenerator.GetNextItemID();
			this.Category = category;
		}
	}
}
