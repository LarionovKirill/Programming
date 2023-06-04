using System;
using System.Windows.Forms;
using TaskWith3FormsAndEvents.Model;

namespace TaskWith3FormsAndEvents
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Contact contact = new Contact();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			for (int i = 0; i < 2; i++)
			{
				ContactForm form = new ContactForm(contact, "SecondaryForm");
				form.Show();
			}
			Application.Run(new ContactForm(contact, "MainForm"));
		}
	}
}
