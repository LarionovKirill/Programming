using System;
using TaskWith3FormsAndEvents;

namespace TaskWith3FormsAndEvents.Model
{
	/// <summary>
	/// Класс контакта.
	/// </summary>
	public class Contact
	{ 
		/// <summary>
		/// Событие изменения имени контакта.
		/// </summary>
		public event EventHandler <ContactEventArgs> FullNameChanged;

		/// <summary>
		/// Событие изменения имени контакта.
		/// </summary>
		public event EventHandler<ContactEventArgs> PhoneNumberChanged;

		/// <summary>
		/// Событие изменения имени контакта.
		/// </summary>
		public event EventHandler<ContactEventArgs> AddressChanged;

		/// <summary>
		/// Имя пользователя в контактах.
		/// </summary>
		private string _fullName = string.Empty;
		
		/// <summary>
		/// Номер контакта.
		/// </summary>
		private string _phoneNumber;

		/// <summary>
		/// Адрес пользователя в контактах.
		/// </summary>
		private string _address;

		/// <summary>
		/// Свойство имени в контакте пользователя.
		/// </summary>
		public string FullName
		{
			get
			{
				return _fullName;
			}
			set
			{
				if (_fullName != value)
				{
					var arg = new ContactEventArgs();
					arg.NewName = value;
					_fullName = value;
					FullNameChanged.Invoke(this, arg);
				}
			}
		}

		/// <summary>
		/// Свойство номера в контакте пользователя.
		/// </summary>
		public string Phone
		{
			get
			{
				return _phoneNumber;
			}
			set
			{
				if (_phoneNumber != value)
				{
					var arg = new ContactEventArgs();
					arg.NewPhone = value;
					_phoneNumber = value;
					PhoneNumberChanged.Invoke(this, arg);
				}
			}
		}

		/// <summary>
		/// Свойство адреса в контакте пользователя.
		/// </summary>
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (_address != value)
				{
					var arg = new ContactEventArgs();
					arg.NewAddress = value;
					_address = value;
					AddressChanged.Invoke(this, arg);
				}
			}
		}
	}
}
