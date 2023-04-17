using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTask.View
{
    public partial class UserInterface : UserControl
    {
        /// <summary>
        /// Список авиаперелетов.
        /// </summary>
        List<Model.AirTravel> _airTravels = new List<Model.AirTravel>();
        
        /// <summary>
        /// Свойство поля _airTravels.
        /// </summary>
        private List<Model.AirTravel> AirTravels
        {
            set 
            {
                _airTravels = value;
            }
            get
            {
                return _airTravels;
            }
        }

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изменение места отправления выбранного объекта.
        /// </summary>
        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = airTravelsListBox.SelectedIndex;
                Model.AirTravel current = AirTravels[index];
                current.Departure = departureTextBox.Text;
                departureTextBox.BackColor = Color.White;
            }
            catch
            {
                departureTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Изменение места прибытия выбранного объекта.
        /// </summary>
        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = airTravelsListBox.SelectedIndex;
                Model.AirTravel current = AirTravels[index];
                current.Destination = departureTextBox.Text;
                destinationTextBox.BackColor = Color.White;
            }
            catch
            {
                destinationTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверяет изменение даты вылета.
        /// </summary>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int index = airTravelsListBox.SelectedIndex;
                Model.AirTravel current = AirTravels[index];
                current.DepartureTime = dateTimePicker.Value;
            }
            catch
            {
                MessageBox.Show("Неверная дата вылета.");
            }
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Model.FlightType)))
            {
                typeOfFlightComboBox.Items.Add(item);
            }
        }
    }
}
