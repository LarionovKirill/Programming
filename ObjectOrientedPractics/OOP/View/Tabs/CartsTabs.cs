using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Tabs
{
    /// <summary>
    /// Логика вкладки корзины.
    /// </summary>
    public partial class CartsTabs : UserControl
    {
        /// <summary>
        /// Свойство хранящее список товаров.
        /// </summary>
        public List<Model.Item> Items{ get;set;}


        /// <summary>
        /// Свойство хранящее список пользователей.
        /// </summary>
        public List<Model.Customer> Customers { get; set; }

        public CartsTabs()
        {
            InitializeComponent();
        }
    }
}
