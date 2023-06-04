using System;
using System.Windows.Forms;
using TaskWith3FormsAndEvents.Model;


namespace TaskWith3FormsAndEvents
{
	public partial class ContactForm : Form
	{
		/// <summary>
		/// Контакт пользователя.
		/// </summary>
		public Contact Contact { get; set; }

		public ContactForm(Contact contact, string name)
		{
			InitializeComponent();
			Contact = contact;
			this.Text = name;
			Contact.FullNameChanged += ChangeFullNameText;
			Contact.PhoneNumberChanged += ChangePhoneText;
			Contact.AddressChanged += ChangedAddressText;
		}

		/// <summary>
		/// Изменение имени в контакте пользователя.
		/// </summary>
		private void FullNameTextBox_TextChanged(object sender, EventArgs e)
		{
			Contact.FullName = fullNameTextBox.Text;
		}

		/// <summary>
		/// Изменение имени на форме контакта.
		/// </summary>
		private void ChangeFullNameText(object sender, EventArgs e)
		{
			if (sender is Contact)
			{
				var gettedContact = (Contact)sender;
				fullNameTextBox.Text = gettedContact.FullName;
			}
		}

		/// <summary>
		/// Изменение номера в контакте пользователя.
		/// </summary>
		private void PhoneTextBox_TextChanged(object sender, EventArgs e)
		{
			Contact.Phone = phoneTextBox.Text;
		}

		/// <summary>
		/// Изменение номера на форме контакта.
		/// </summary>
		private void ChangePhoneText(object sender, EventArgs e)
		{
			if (e is ContactEventArgs)
			{
				// Я понял, что можно пойти 2 путями. Какой из них верный,
				// наверное, смотреть по ситуации. 
				//var gettedContact = (Contact)sender;
				var gettedInfo = (ContactEventArgs)e;
				phoneTextBox.Text = gettedInfo.NewPhone;
			}
		}

		/// <summary>
		/// Изменяет адрес в контакте пользователя.
		/// </summary>
		private void AddressTextBox_TextChanged(object sender, EventArgs e)
		{
			Contact.Address = addressTextBox.Text;
		}

		/// <summary>
		/// Изменяет адрес в форме контакта.
		/// </summary>
		private void ChangedAddressText(object sender, EventArgs e)
		{
			if (sender is Contact)
			{
				var gettedContact = (Contact)sender;
				addressTextBox.Text = gettedContact.Address;
			}
		}

		/// <summary>
		/// Отписывает методы от события и закывает форму.
		/// </summary>
		private void CloseButton_Click(object sender, EventArgs e)
		{
			Contact.FullNameChanged -= ChangeFullNameText;
			Contact.PhoneNumberChanged -= ChangePhoneText;
			Contact.AddressChanged -= ChangedAddressText;
			this.Close();
		}
	}
}
