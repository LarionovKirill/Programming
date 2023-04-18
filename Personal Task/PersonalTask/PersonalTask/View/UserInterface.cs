using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
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
        /// Метод, который срабатывает при загрузке интерфейса.
        /// </summary>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Model.FlightType)))
            {
                typeOfFlightComboBox.Items.Add(item);
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

        /// <summary>
        /// Метод при наведении на кнопку редактирования делает ее более тусклой.
        /// </summary>
        private void ChangePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            changePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "ChangeButtonContrast");
        }

        /// <summary>
        /// Метод возвращает контраст кнопки редактирования при покидании курсора.
        /// </summary>
        private void ChangePictureBox_MouseLeave(object sender, EventArgs e)
        {
            changePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "ChangeButton");
        }

        /// <summary>
        /// Метод при наведении на кнопку удаления делает ее более тусклой.
        /// </summary>
        private void DeletePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            deletePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "DeleteButtonContrast");
        }

        /// <summary>
        /// Метод возвращает контраст кнопки удаления при покидании курсора.
        /// </summary>
        private void DeletePictureBox_MouseLeave(object sender, EventArgs e)
        {
            deletePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "DeleteButton");
        }

        /// <summary>
        /// Метод при наведении на кнопку удаления делает ее более тусклой.
        /// </summary>
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            addPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "GreenAddButtonContrast");
        }

        /// <summary>
        /// Метод возвращает контраст кнопки удаления при покидании курсора.
        /// </summary>
        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            addPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                "GreenAddButton");
        }

        /// <summary>
        /// Обработка нажати кнопки добавить.
        /// </summary>
        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _airTravels.Add(new Model.AirTravel(
                departureTextBox.Text,
                destinationTextBox.Text,
                departureTime.Value,
                int.Parse(flightTimeTextBox.Text),
                (Model.FlightType)Enum.Parse(typeof(Model.FlightType),
                typeOfFlightComboBox.SelectedItem.ToString())));
            airTravelsListBox.Items.Add(CreateStringForList(_airTravels.Last()));
        }

        /// <summary>
        /// Метод формирует строку для вывода.
        /// </summary>
        /// <param name="current"> Объект класса AirTravel, откуда берется информация.</param>
        /// <returns></returns>
        private string CreateStringForList(Model.AirTravel current)
        {
            string finalString;
            finalString = $"{current.DepartureTime.ToShortDateString()}: {current.Departure}" +
                $" - {current.Destination} ";
            return finalString;
        }

        /// <summary>
        /// Метод удаляет выбранный авиаперелет из списка из списка.
        /// </summary>
        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            int index = airTravelsListBox.SelectedIndex;
            airTravelsListBox.SelectedIndex = index - 1;
            airTravelsListBox.Items.RemoveAt(index);
            _airTravels.RemoveAt(index);
        }

        /// <summary>
        /// Метод заполняет информация о перелете по выбранному элементу из списка.
        /// </summary>
        private void AirTravelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = airTravelsListBox.SelectedIndex;
            ToFillInformationAboutAirTravel(_airTravels[index]);
        }

        /// <summary>
        /// Заполняет информация о перелете в поля textbox'ов.
        /// </summary>
        private void ToFillInformationAboutAirTravel(Model.AirTravel current)
        {
            departureTextBox.Text = current.Departure;
            destinationTextBox.Text = current.Destination;
            departureTime.Value = current.DepartureTime;
            typeOfFlightComboBox.Text = current.FlightType.ToString();
            flightTimeTextBox.Text = current.FlightTime.ToString();
        }
    }
}
