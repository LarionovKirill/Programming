﻿using System;
using OOP.Model.Enums;

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
		public Item(string name, string info, decimal  cost, ItemCategory category)
		{
			this.Info = info;
			this.Name = name;
			this.Cost = cost;
			this.Id = Services.IdGenerator.GetNextItemID();
			this.ItemCategory = category;
		}

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
	}
}
