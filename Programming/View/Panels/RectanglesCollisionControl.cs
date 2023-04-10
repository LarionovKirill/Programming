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
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников класса Rectangle.
        /// </summary>
        List<Model.Rectangle> rectangles = new List<Model.Rectangle>();

        /// <summary>
        /// Список панелей.
        /// </summary>
        List<Panel> _panels = new List<Panel>();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет прямоугольник в ListBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void buttonAddRectangle_Click(object sender, EventArgs e)
        {
            //Работа с полями прямоугольника.
            Model.Rectangle currentRectangle = Model.RectangleFactory.Randomize(
                panelForRectangles.Width,
               panelForRectangles.Height
               );
            string text = CreateStringWithRectangleParameters(
                currentRectangle.Id,
                currentRectangle.Center.X,
                currentRectangle.Center.Y,
                currentRectangle.Width,
                currentRectangle.Length
                );
            rectanglesListBox.Items.Insert(rectangles.Count, text);
            rectangles.Add(currentRectangle);
            //Работа с панелью.
            Panel _currentPanel = new Panel();
            _currentPanel.Location = new Point(
                (int)currentRectangle.Center.X,
                (int)currentRectangle.Center.Y
                );
            _currentPanel.Width = int.Parse(currentRectangle.Width.ToString());
            _currentPanel.Height = int.Parse(currentRectangle.Length.ToString());
            _currentPanel.BackColor = Model.AppColors.simpleRectangle;
            _panels.Add(_currentPanel);
            panelForRectangles.Controls.Add(_currentPanel);
            FindCollisions();
        }

        /// <summary>
        /// Удаляет прямоугольник в ListBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void buttonRemoveRectangle_Click(object sender, EventArgs e)
        {
            var index = rectanglesListBox.SelectedIndex;
            if (index >= 0)
            {
                rectangles.RemoveAt(index);
                rectanglesListBox.Items.RemoveAt(index);
                _panels.RemoveAt(index);
                panelForRectangles.Controls.RemoveAt(index);
                FindCollisions();
            }
        }

        /// <summary>
        /// Заполняет TextBox выбранного прямоугольника.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = rectanglesListBox.SelectedIndex;
            if (index < 0)
            {
                ClearRectangleInfo();
            }
            else
            {
                Model.Rectangle currentRectangle = rectangles[index];
                UpdateRectangleInfo(currentRectangle);
            }
        }

        /// <summary>
        /// Обработка изменений поля координаты x.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = rectangles[index];
                if (int.Parse(xTextBox.Text) + currentRectangle.Width <= panelForRectangles.Width)
                {
                    rectangles[index].Center.X = int.Parse(xTextBox.Text);
                    xTextBox.BackColor = System.Drawing.Color.White;
                    Point point = new Point();
                    point.X = (int)currentRectangle.Center.X;
                    point.Y = (int)currentRectangle.Center.Y;
                    _panels[index].Location = point;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    xTextBox.BackColor = Model.AppColors.intersectingRectangle;
                }
            }
            catch
            {
                xTextBox.BackColor = Model.AppColors.intersectingRectangle;
            }
            finally
            {
                if (xTextBox.Text == string.Empty)
                {
                    xTextBox.BackColor = System.Drawing.Color.White;
                }
            }
        }

        /// <summary>
        /// Обработка изменений поля координаты y.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = rectangles[index];
                if (int.Parse(yTextBox.Text) + currentRectangle.Length <= panelForRectangles.Height)
                {
                    rectangles[index].Center.Y = int.Parse(yTextBox.Text);
                    yTextBox.BackColor = System.Drawing.Color.White;
                    Point point = new Point();
                    point.X = (int)currentRectangle.Center.X;
                    point.Y = (int)currentRectangle.Center.Y;
                    _panels[index].Location = point;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    yTextBox.BackColor = Model.AppColors.intersectingRectangle;
                }
            }
            catch
            {
                yTextBox.BackColor = Model.AppColors.intersectingRectangle;
            }
            finally
            {
                if (yTextBox.Text == string.Empty)
                {
                    yTextBox.BackColor = System.Drawing.Color.White;
                }
            }
        }

        /// <summary>
        /// Обработка изменений поля ширины.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void widthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = rectangles[index];
                if (int.Parse(widthRectangleTextBox.Text) + currentRectangle.Center.X
                    <= panelForRectangles.Width)
                {
                    rectangles[index].Width = double.Parse(widthRectangleTextBox.Text);
                    widthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    _panels[index].Width = (int)currentRectangle.Width;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    widthRectangleTextBox.BackColor = Model.AppColors.intersectingRectangle;
                }
            }
            catch
            {
                widthRectangleTextBox.BackColor = Model.AppColors.intersectingRectangle;
            }
            finally
            {
                if (widthRectangleTextBox.Text == string.Empty)
                {
                    widthRectangleTextBox.BackColor = System.Drawing.Color.White;
                }
            }
        }

        /// <summary>
        /// Обработка изменений поля ширины.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void lengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = rectangles[index];
                if (int.Parse(lengthRectangleTextBox.Text) + currentRectangle.Center.Y
                    <= panelForRectangles.Height)
                {
                    rectangles[index].Length = double.Parse(lengthRectangleTextBox.Text);
                    lengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    _panels[index].Height = (int)currentRectangle.Length;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    lengthRectangleTextBox.BackColor = Model.AppColors.intersectingRectangle;
                }
            }
            catch
            {
                lengthRectangleTextBox.BackColor = Model.AppColors.intersectingRectangle;
            }
            finally
            {
                if (lengthRectangleTextBox.Text == string.Empty)
                {
                    lengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                }
            }
        }

        /// <summary>
        /// Создает строку для вывода ее в ListBox
        /// </summary>
        /// <param name="id">Id прямоугольника.</param>
        /// <param name="x">Координата x.</param>
        /// <param name="y">Координат y.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="height">Высота прямоугольника.</param>
        /// <returns>Возвращает готовую для вставки строку.</returns>
        private string CreateStringWithRectangleParameters(
            int id,
            double x,
            double y,
            double width,
            double height
            )
        {
            return $"{id}:(X ={x}; Y={y}; W={width}; H={height})";
        }

        /// <summary>
        /// Находит коллизии прямоугольников на панели и перекрашивает пересекающиеся
        /// прямоугольники в красный
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _panels.Count; i++)
            {
                _panels[i].BackColor = Model.AppColors.simpleRectangle;
            }
            for (int i =0; i < rectangles.Count; i++)
            {
                for (int j = 0; j < rectangles.Count; j++)
                {
                    if (rectangles[i] == rectangles[j])
                    {
                        continue;
                    }
                    else
                    {
                        if (Model.CollisionManager.IsCollision(rectangles[i], rectangles[j]))
                        {
                            _panels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                            _panels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод очищает поля прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            widthRectangleTextBox.Text = String.Empty;
            lengthRectangleTextBox.Text = String.Empty;
            idTextBox.Text = String.Empty;
            xTextBox.Text = String.Empty;
            yTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Метод выполняет обновление данных в текстовых полях по указанному прямоугольнику.
        /// </summary>
        /// <param name="rectangle"></param>
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            widthRectangleTextBox.Text = rectangle.Width.ToString();
            lengthRectangleTextBox.Text = rectangle.Length.ToString();
            idTextBox.Text = rectangle.Id.ToString();
            xTextBox.Text = rectangle.Center.X.ToString();
            yTextBox.Text = rectangle.Center.Y.ToString();
        }

        /// <summary>
        /// Метод производит изменения в ListBox прямоугольника.
        /// </summary>
        /// <param name="index">Индекс строки в ListBox</param>
        /// <param name="currentRectangle">Прямоугольник с текущими значениями.</param>
        private void ChangingParametersOfRectangle(int index, Model.Rectangle currentRectangle)
        {
            string text = CreateStringWithRectangleParameters(
                currentRectangle.Id,
                currentRectangle.Center.X,
                currentRectangle.Center.Y,
                currentRectangle.Width,
                currentRectangle.Length
                );
            rectanglesListBox.Items.Insert(index, text);
            rectanglesListBox.SelectedIndex = index;
            rectanglesListBox.Items.RemoveAt(index + 1);
            FindCollisions();
        }
    }
}
