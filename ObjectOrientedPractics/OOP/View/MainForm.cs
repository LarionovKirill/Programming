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


        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = Store.Items;
            customerTab2.Customers = Store.Customers;
        }
    }
}
