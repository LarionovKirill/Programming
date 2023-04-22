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
    public partial class ChangingForm : Form
    {
        public ChangingForm()
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
                PersonalTask.Services.ColissionManager.AssertOnLengthOfString(
                    destinationTextBox.Text,
                    100,
                    "Длина строки не должна превышать 100 символов.");
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
                PersonalTask.Services.ColissionManager.AssertOnLengthOfString(
                    destinationTextBox.Text,
                    100,
                    "Длина строки не должна превышать 100 символов.");
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
        private void DepartureTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                PersonalTask.Services.ColissionManager.AssertDepartureTime(
                    departureTime.Value,
                    "Неверная дата вылета."
                    );
            }
            catch
            {
                MessageBox.Show("Неверная дата вылета.");
            }
        }

        /// <summary>
        /// Проверка на длительность полета.
        /// </summary>
        private void TimeFlightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (flightTimeTextBox.Text.Length > 0)
                {
                    PersonalTask.Services.ColissionManager.AssertFlightTime(
                        int.Parse(flightTimeTextBox.Text),
                        1000,
                        "Время полета не должно превышать 1000 минут."
                        );
                }
                flightTimeTextBox.BackColor = Color.White;
            }
            catch
            {
                flightTimeTextBox.BackColor = Color.Pink;
                MessageBox.Show("Время полета от 1 до 1000 минут.");
            }
        }
    }
}
