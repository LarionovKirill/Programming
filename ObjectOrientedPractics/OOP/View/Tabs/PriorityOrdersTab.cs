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
    /// Класс элемента приоритетного заказа.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Свойство приоритетного заказа.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Model.PriorityOrder PriorityOrder { get; set; }

        /// <summary>
        /// Словарь, хранящий перечисление и их значение.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Dictionary<Model.DeliveryTime, string> TimeDelivery { get; set; }

        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод выполняется при запуске формы.
        /// </summary>
        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            var statuses = Enum.GetValues(typeof(Model.OrderStatus));
            foreach (var item in statuses)
            {
                statusComboBox.Items.Add(item);
            }
            TimeDelivery = Services.EnumGetter.GetDeliveryTime();

            foreach (var item in TimeDelivery)
            {
                deliveryTimeComboBox.Items.Add(item);
            }
        }
    }
}
