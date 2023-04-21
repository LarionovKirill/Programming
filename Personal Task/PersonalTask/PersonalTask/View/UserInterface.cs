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

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


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

        /// <summary>
        /// Инициализация компонентов пользовательского интерфейса.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            Deserialize();
        }

        /// <summary>
        /// Сериализация данных.
        /// Реализация взята из: https://learn.microsoft.com/ru-ru/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-core-3-1
        /// </summary>
        private void Serialize()
        {
            var path = "AirTravels.json";
            var contents = JsonSerializer.Serialize(AirTravels);
            File.WriteAllText(path, contents);
        }

        /// <summary>
        /// Десериализация данных.
        /// Реализация взята из: https://learn.microsoft.com/ru-ru/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-core-3-1
        /// </summary>
        private void Deserialize()
        {

            var path = "AirTravels.json";
            var jsonString = File.ReadAllText(path);
            if (jsonString != string.Empty)
            {
                var takedInformation = JsonSerializer.Deserialize<List<Model.AirTravel>>(jsonString);
                foreach (var items in takedInformation)
                {
                    if (items != null)
                    {
                        AirTravels.Add(items);
                        airTravelsListBox.Items.Add(CreateStringForList(AirTravels.Last()));
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который срабатывает при загрузке интерфейса.
        /// </summary>
        private void UserInterface_Load(object sender, EventArgs e)
        {

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
            ChangingForm test = new ChangingForm();
            test.agreeButton.Text = "Добавить перелет";
            test.cancelButton.Text = "Отмена";
            foreach (var item in Enum.GetValues(typeof(Model.FlightType)))
            {
                test.typeOfFlightComboBox.Items.Add(item);
            }
            test.ShowDialog();
            if (test.agreeButton.DialogResult == DialogResult.Yes)
            {
                _airTravels.Add(new Model.AirTravel(
                test.departureTextBox.Text,
                test.destinationTextBox.Text,
                test.departureTime.Value,
                int.Parse(test.flightTimeTextBox.Text),
                (Model.FlightType)Enum.Parse(typeof(Model.FlightType),
                test.typeOfFlightComboBox.SelectedItem.ToString())));
                airTravelsListBox.Items.Add(CreateStringForList(_airTravels.Last()));
                SortData();
                Serialize();
                test.Close();
            }
            else if (test.cancelButton.DialogResult == DialogResult.No)
            {
                test.Close();
            }
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
            Serialize();
        }

        /// <summary>
        /// Метод заполняет информация о перелете по выбранному элементу из списка.
        /// </summary>
        private void AirTravelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (airTravelsListBox.SelectedIndex >= 0)
            {
                int index = airTravelsListBox.SelectedIndex;
                ToFillInformationAboutAirTravel(_airTravels[index]);
            }
        }

        /// <summary>
        /// Заполняет информация о перелете в поля textbox'ов.
        /// </summary>
        private void ToFillInformationAboutAirTravel(Model.AirTravel current)
        {
            departureTextBox.Text = current.Departure;
            destinationTextBox.Text = current.Destination;
            typeOfFlightTextBox.Text = current.FlightType.ToString();
            departureTimeTextBox.Text = current.DepartureTime.Date.ToString("dd.MM.yyyy");
            flightTimeTextBox.Text = current.FlightTime.ToString();
        }

        /// <summary>
        /// Метод обрабатывает изменения выбранного перелета
        /// </summary>
        private void ChangePictureBox_Click(object sender, EventArgs e)
        {
            if (airTravelsListBox.SelectedIndex >= 0)
            {
                ChangingForm test = new ChangingForm();
                int index = airTravelsListBox.SelectedIndex;
                test.departureTextBox.Text = AirTravels[index].Departure;
                test.destinationTextBox.Text = AirTravels[index].Destination;
                test.departureTime.Value = AirTravels[index].DepartureTime;
                test.flightTimeTextBox.Text = AirTravels[index].FlightTime.ToString();
                foreach (var item in Enum.GetValues(typeof(Model.FlightType)))
                {
                    test.typeOfFlightComboBox.Items.Add(item);
                }
                test.typeOfFlightComboBox.SelectedItem = AirTravels[index].FlightType;
                test.ShowDialog();
                if (test.agreeButton.DialogResult == DialogResult.Yes)
                {
                    AirTravels[index].Departure = test.departureTextBox.Text;
                    AirTravels[index].Destination = test.destinationTextBox.Text;
                    AirTravels[index].DepartureTime = test.departureTime.Value;
                    AirTravels[index].FlightType = (Model.FlightType)Enum.Parse(typeof(Model.FlightType),
                        test.typeOfFlightComboBox.SelectedItem.ToString());
                    AirTravels[index].FlightTime = int.Parse(test.flightTimeTextBox.Text);
                    ToFillInformationAboutAirTravel(AirTravels[index]);
                    airTravelsListBox.Items[index] = CreateStringForList(AirTravels[index]);
                    SortData();
                    Serialize();
                    test.Close();
                }
                else if (test.cancelButton.DialogResult == DialogResult.No)
                {
                    test.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите перелет, который хотите изменить.");
            }
        }

        /// <summary>
        /// Метод сортирует метода пузырька данные по дате вылета.
        /// </summary>
        private void SortData()
        {
            int itearation = _airTravels.Count;
            for (int i = 0; i < itearation; i++)
            {
                for (int j = 0; j < itearation - 1 - i; j++)
                {
                    if (_airTravels[j].DepartureTime > _airTravels[j + 1].DepartureTime)
                    {
                        (_airTravels[j], _airTravels[j + 1]) = 
                            (_airTravels[j + 1], _airTravels[j]);
                        (airTravelsListBox.Items[j], airTravelsListBox.Items[j + 1]) =
                            (airTravelsListBox.Items[j + 1], airTravelsListBox.Items[j]);
                    }
                }
            }
        }
    }
}
