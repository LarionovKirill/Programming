using System;
using OOP.Model.Enums;
using OOP.Model.EventsArgs;

namespace OOP.Model
{
	/// <summary>
	/// Класс товар.
	/// </summary>
	public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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
				ItemEventsArgs args = new ItemEventsArgs();
				args.NewName = value;
				this.NameChanged?.Invoke(this, args);
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
				ItemEventsArgs args = new ItemEventsArgs();
				args.NewInfo = value;
				this.InfoChanged?.Invoke(this, args);
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
				ItemEventsArgs args = new ItemEventsArgs();
				args.NewCost = value;
				this.CostChanged?.Invoke(this, args);
			}
			get
			{
				return _cost;
			}
		}

		/// <summary>
		/// Свойство категории товаров.
		/// </summary>
		public ItemCategory ItemCategory { get; set; }

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Item()
		{

		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="name">Имя товара.</param>
		/// <param name="info">Информация о товаре.</param>
		/// <param name="cost">Цена товара.</param>
		/// <param name="category">Категория товара.</param>
		public Item(string name, string info, decimal cost, ItemCategory category)
		{
			this.Info = info;
			this.Name = name;
			this.Cost = cost;
			this.Id = Services.IdGenerator.GetNextItemID();
			this.ItemCategory = category;
		}

		/// <summary>
		/// Событие изменения имени товара.
		/// </summary>
		public event EventHandler <ItemEventsArgs> NameChanged;

		/// <summary>
		/// Событие изменения цены товара.
		/// </summary>
		public event EventHandler <ItemEventsArgs> CostChanged;

		/// <summary>
		/// Событие изменения информации товара.
		/// </summary>
		public event EventHandler <ItemEventsArgs> InfoChanged;

		/// <summary>
		/// Копирует информацию из вызващего класса.
		/// </summary>
		public void CopyInformation(Item item)
		{
			item.Id = this.Id;
			item.Info = this.Info;
			item.ItemCategory = this.ItemCategory;
			item.Name = this.Name;
			item.Cost = this.Cost;
		}


		/// <summary>
		/// Реализация копирования от стандартного интерфейса ICloneable.
		/// </summary>
		/// <returns>Возвращает копию объекта класса <see cref="Item"/>.</returns>
		public object Clone()
		{
			return new Item(this.Name, this.Info, this.Cost, this.ItemCategory);
		}

		/// <summary>
		/// Перегрузка метода Equals.
		/// </summary>
		/// <param name="other">Сравниваемый объект.</param>
		/// <returns>True, если равны названия, тип товара и цена, иначе false.</returns>
		public override bool Equals(object other)
		{
			//Проверка на наличие объекта.
			if (other == null)
			{
				return false;
			}

			//Проверка на один тип.
			if (other.GetType() != typeof(Item))
			{
				return false;
			}

			//Проверка на одинаковые ссылки.
			if (object.ReferenceEquals(this, other))
			{
				return true;
			}

			var item2 = (Item)other;
			return (
				item2.Name == this.Name &&
				item2.ItemCategory == this.ItemCategory &&
				item2.Cost == this.Cost);
		}


		/// <summary>
		/// Перегрузка метода Equals.
		/// </summary>
		/// <param name="other">Сравниваемый объект тип Item</param>
		/// <returns>True, если равны названия, тип товара и цена, иначе false.</returns>
		public bool Equals(Item other)
		{
			return (
				other.Name == this.Name &&
				other.ItemCategory == this.ItemCategory &&
				other.Cost == this.Cost);
		}

		/// <summary>
		/// Реализует сравнение классов <see cref="Item"/> по стоимости.
		/// </summary>
		/// <param name="other">Сравниваемый объект.</param>
		/// <returns>Метод должен возвращать 0, если стоимости равны; 1, если стоимость исходного объекта
		/// больше передаваемого в метод; и -1, если стоимость исходного объекта меньше
		/// передаваемого в метод.
		/// </returns>
		public int CompareTo(Item other)
		{
			if (this.Cost == other.Cost)
			{
				return 0;
			}
			else if (this.Cost < other.Cost)
			{
				return -1;
			}
			else
			{
				return 1;
			}
		}
	}
}
