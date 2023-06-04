using System;

namespace TaskWith3FormsAndEvents.Model
{
	/// <summary>
	/// Класс методов события контакта, отнаследованный от <see	cref= "EventArgs"></see>
	/// </summary>
	public class ContactEventArgs : EventArgs
	{
		/// <summary>
		/// Новое имя в контакте.
		/// </summary>
		public string NewName { get; set; }

		/// <summary>
		/// Новый телефон в контакте.
		/// </summary>
		public string NewPhone { get; set; }

		/// <summary>
		/// Новый адрес в контакте.
		/// </summary>
		public string NewAddress { get; set; }

		/// <summary>
		/// Конструктор класса <see cref = "ContactEventArgs"></see> без параметров.
		/// </summary>
		public ContactEventArgs()
		{
			
		}
	}
}
