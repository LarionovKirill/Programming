using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectangleListControl : UserControl
    {
        /// <summary>
        /// Количество элементов для генерирования объектов.
        /// </summary>
        const int countItems = 5;

        /// <summary>
        /// Список прямоугольников класса Rectangle.
        /// </summary>
        List<Model.Rectangle> _rectangles = new List<Model.Rectangle>();
        public RectangleListControl()
        {
            InitializeComponent();
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
            int index = rectangleListBox.SelectedIndex;
            Model.Rectangle current = _rectangles[index];
            lengthTextBox.Text = current.Length.ToString();
            widthTextBox.Text = current.Width.ToString();
            colorTextBox.Text = current.Color.ToString();
            xRectangleTextBox.Text = current.Center.X.ToString();
            yRectangleTextBox.Text = current.Center.Y.ToString();
            IdRectangleTextBox.Text = current.Id.ToString();

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
            for (int i = 0; i < countItems; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxRectanlgeIndex = i;
                    maxWidth = _rectangles[i].Width;
                }
            }
            rectangleListBox.SelectedIndex = maxRectanlgeIndex;
        }

        /// <summary>
        /// Проверяет изменения длины в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void LengthTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectangleListBox.SelectedIndex;
                _rectangles[index].Length = double.Parse(lengthTextBox.Text);
                lengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                lengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения ширины в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void WidthTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectangleListBox.SelectedIndex;
                _rectangles[index].Width = double.Parse(widthTextBox.Text);
                widthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                widthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения цвета в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void ColorTextChanged(object sender, EventArgs e)
        {
            bool check = Enum.IsDefined(typeof(Model.Enums.Color), colorTextBox.Text);
            if (check)
            {
                int index = rectangleListBox.SelectedIndex;
                _rectangles[index].Color = colorTextBox.Text;
                colorTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                colorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Метод запускается при запуске интерфейса с прямоугольниками и заполянет их.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void RectangleListControl_Load(object sender, EventArgs e)
        {
            int countOfColors = Enum.GetNames(typeof(Model.Enums.Color)).Length;
            Random random = new Random();
            //Заполнение listbox 
            for (int i = 0; i < countItems; i++)
            {
                ///Заполнеение прямоугольников
                Model.Enums.Color color;
                double length = random.Next(1, 51);
                double width = random.Next(1, 51);
                color = (Model.Enums.Color)random.Next(countOfColors);
                Model.Point2D point = new Model.Point2D(random.Next(0, 100), random.Next(0, 100));
                _rectangles.Add(new Model.Rectangle(length, width, color.ToString(), point));
                rectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
            rectangleListBox.SelectedIndex = 0;
        }
    }
}
