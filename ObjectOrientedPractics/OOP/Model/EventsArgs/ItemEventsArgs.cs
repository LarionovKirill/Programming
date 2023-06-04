﻿
namespace OOP.Model.EventsArgs
{
	/// <summary>
	/// Класс хранит новые аргументы товара для передачи их в события.
	/// </summary>
	public class ItemEventsArgs
	{
		/// <summary>
		/// Свойство нового имени товара.
		/// </summary>
		public string NewName { get; set; }

		/// <summary>
		/// Свойство новой цены товара.
		/// </summary>
		public decimal NewCost { get; set; }

		/// <summary>
		/// Свойство нового описания товара.
		/// </summary>
		public string NewInfo { get; set; }
	}
}
