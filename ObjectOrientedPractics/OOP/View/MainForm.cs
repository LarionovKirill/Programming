using System;
using System.Windows.Forms;
using OOP.View.Tabs;

namespace OOP
{
    /// <summary>
    /// Класс главной формы.
    /// </summary>
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
            Store.Items = Services.ItemGenerator.GenerateListOfItems();

            itemsTab1.Items = Store.Items;
            itemsTab1.UpdateInformation(itemsTab1.Items);

            Store.Customers = Services.CustomerGenerator.GenerateListOfCustomers();
            customerTab2.Customers = Store.Customers;
            customerTab2.UpdateInformation();

            cartsTab.Customers = Store.Customers;
            cartsTab.Items = Store.Items;

            ordersTab1.Customers = Store.Customers;

            itemsTab1.ItemsChanged += new ItemsTab.ChangeItem(cartsTab.RefreshData);
            itemsTab1.ItemsChanged += new ItemsTab.ChangeItem(ordersTab1.UpdateInformation);
            itemsTab1.ItemsChanged += new ItemsTab.ChangeItem(customerTab2.Fill);
        }

        /// <summary>
        /// Обрабочик перехода на форму корзины
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                cartsTab.RefreshData();
            }
            else if (tabControl.SelectedIndex == 3)
            {
                ordersTab1.UpdateInformation();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                customerTab2.Fill();
            }
        }
    }
}
