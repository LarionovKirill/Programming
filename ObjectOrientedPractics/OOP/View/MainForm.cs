using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса Store, хранящий пользователей и товары.
        /// </summary>
        private Model.Store _store = new Model.Store();

        /// <summary>
        /// Свойство поля _store.
        /// </summary>
        public Model.Store Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
            }
        }

        /// <summary>
        /// Метод, который запускается при запуске приложения.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Store.Items = Services.ItemGeneretor.GenerateListOfItems();
            itemsTab.Items = Store.Items;
            itemsTab.UpdateInformation();
            Store.Customers = Services.CustomerGenerator.GenerateListOfCustomers();
            customerTab2.Customers = Store.Customers;
            customerTab2.UpdateInformation();
            cartsTab.Customers = Store.Customers;
            cartsTab.Items = Store.Items;
        }

        /// <summary>
        /// Обрабочик перехода на форму корзины
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                cartsTab.Customers = Store.Customers;
                cartsTab.Items = Store.Items;
                cartsTab.RefreshData();
            }
        }
    }
}
