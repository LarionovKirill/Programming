using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        const int countRactangles = 5;
        Model.Rectangle[] _rectangles = new Model.Rectangle[countRactangles];

        public MainForm()
        {
            InitializeComponent();
            var enums = new []
            { 
                "Color",
                "EducationForm",
                "Genre",
                "Manufacturer",
                "Season",
                "WeekDay"
            };
            enumsListBox.Items.AddRange(enums);
            Model.Enums.Color color;
            int countOfColors = Enum.GetNames(typeof(Model.Enums.Color)).Length;

            for (int i = 0; i < countRactangles; i++)
            {
                _rectangles[i] = new Model.Rectangle();
                RectangleListBox.Items.Add($"Rectangle {i+1}");
                _rectangles[i].length = random.Next(1,51);
                _rectangles[i].width = random.Next(1, 51);
                color = (Model.Enums.Color)random.Next(countOfColors);
                _rectangles[i].color = color.ToString();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие и создает список перечислений.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enumsDict = new Dictionary<int, Enum>
            {
                [0] = new Model.Enums.Color(),
                [1] = new EducationForm(),
                [2] = new Genre(),
                [3] = new Manufacturer(),
                [4] = new Season(),
                [5] = new WeekDay(),
            };
            valuesListBox.Items.Clear();
            intValues.Text = String.Empty;
            var elementNumber = enumsListBox.SelectedIndex;
            var a = enumsDict[elementNumber].GetType();
            foreach (var item in Enum.GetValues(a))
            {
                valuesListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Выдает числовое значение перечисления.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValues.Text = valuesListBox.SelectedIndex.ToString();
        }

         /// <summary>
        /// Проверяет, что написанное значение это день недели.    
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            var day = days.Text;
            WeekDay seasonCheck;
            var check = Enum.TryParse(day,out seasonCheck);
            if (check)
            {
                WeekDay Answer = (WeekDay) Enum.Parse(typeof(WeekDay), day,ignoreCase: true);
                answerLabel.Text = $"«Это день недели ({Answer} = {(int)Answer+1})";
            }
            else
            {
                answerLabel.Text = "Нет такого дня недели";
            }
        }

        /// <summary>
        /// Проверяет, что выбранное значение это время года.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            seasonAnswer.Text = String.Empty;
            seasonHandleBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            switch (seasonBox.SelectedItem)
            {
                case "Winter":
                {
                        seasonAnswer.Text = "Бррр! Холодно!";
                        break;
                }
                case "Spring":
                {
                        seasonHandleBox.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                }
                case "Summer":
                {
                        seasonAnswer.Text = "Ура! Солнце!";
                        break;
                }
                case "Autumn":
                {
                        seasonHandleBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                }
                default:
                {
                        seasonAnswer.Text = "Это не время года";
                        break;
                }
            }
        }

        /// <summary>
        /// Заполняет TextBox при нажатии элемента из ListBox
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RectangleListBox.SelectedIndex;
            LengthTextBox.Text = _rectangles[index].length.ToString();
            WidthTextBox.Text = _rectangles[index].width.ToString();
            ColorTextBox.Text = _rectangles[index].color.ToString();
        }

        /// <summary>
        /// Ищет прямоугольник с максимальной шириной и устанавливает его в поле.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void FindRectangleWithMaxWidth(object sender, EventArgs e)
        {
            int maxRectanlgeIndex = 0;
            double maxWidth = 0d;
            for (int i = 0; i < countRactangles;i++)
            {
                if (_rectangles[i].width > maxWidth)
                {
                    maxRectanlgeIndex = i;
                    maxWidth = _rectangles[i].width;
                }
            }
            RectangleListBox.SelectedIndex = maxRectanlgeIndex;
        }
    }
}
