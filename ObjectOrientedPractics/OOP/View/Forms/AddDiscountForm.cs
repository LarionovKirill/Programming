using System;
using System.Windows.Forms;
using OOP.Model.Enums;

namespace OOP.View.Forms
{
    /// <summary>
    /// Форма для добавления скидки.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, возникающий при запуске формы.
        /// </summary>
        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            var category = Enum.GetValues(typeof(ItemCategory));
            foreach (var item in category)
            {
                discountsComboBox.Items.Add(item);
            }
            discountsComboBox.SelectedIndex = 0;
        }
    }
}
