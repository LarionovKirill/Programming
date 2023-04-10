using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Количество элементов для генерирования объектов.
        /// </summary>
        const int _countItems = 5;

        /// <summary>
        /// Массив элементов класса Film.
        /// </summary>
        Films[] _films = new Films[_countItems];

        /// <summary>
        /// Список прямоугольников класса Rectangle.
        /// </summary>
        List<Model.Rectangle> _rectangles = new List<Model.Rectangle>();

        /// <summary>
        /// Список панелей.
        /// </summary>
        List<Panel> panels = new List<Panel>();

        /// <summary>
        /// Главный метод, который запускается с программой.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            var enums = new[]
            {
                "Color",
                "EducationForm",
                "Genre",
                "Manufacturer",
                "Season",
                "WeekDay"
            };
            enumsListBox.Items.AddRange(enums);
            enumsListBox.SelectedIndex = 0;
            int countOfGenre = Enum.GetNames(typeof(Genre)).Length;
            int countOfColors = Enum.GetNames(typeof(Model.Enums.Color)).Length;
            Random random = new Random();
            //Заполнение listbox 
            for (int i = 0; i < _countItems; i++)
            {
                ///Заполнеение прямоугольников
                Model.Enums.Color color;
                double length = random.Next(1, 51);
                double width = random.Next(1, 51);
                color = (Model.Enums.Color)random.Next(countOfColors);
                Point2D point = new Point2D(random.Next(0, 100), random.Next(0, 100));
                _rectangles.Add(new Model.Rectangle(length, width, color.ToString(), point));
                rectangleListBox.Items.Add($"Rectangle {i + 1}");

                //Заполнение фильмов
                Genre genre;
                _films[i] = new Films();
                filmsListBox.Items.Add($"Film {i + 1}");
                _films[i].YearOfRelease = random.Next(1900, 2024);
                genre = (Genre)random.Next(countOfGenre);
                _films[i].Genre = genre.ToString();
                _films[i].Rating = random.Next(1, 101) / 10d;
                _films[i].Duration = random.Next(80, 300);
                _films[i].Title = Convert.ToChar(random.Next(65, 133)).ToString();
            }
            filmsListBox.SelectedIndex = 0;
            rectangleListBox.SelectedIndex = 0;
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
            var enums = new Dictionary<string, Type>
            {
                [nameof(Model.Enums.Color)] = typeof(Model.Enums.Color),
                [nameof(EducationForm)] = typeof(EducationForm),
                [nameof(Genre)] = typeof(Genre),
                [nameof(Manufacturer)] = typeof(Manufacturer),
                [nameof(Season)] = typeof(Season),
                [nameof(WeekDay)] = typeof(WeekDay),
            };
            valuesListBox.Items.Clear();
            intValues.Text = string.Empty;
            var element = enumsListBox.SelectedItem.ToString();
            var output = enums[element];
            foreach (var item in Enum.GetValues(output))
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
            var check = Enum.TryParse(day, out seasonCheck);
            if (check)
            {
                WeekDay аnswer = (WeekDay)Enum.Parse(typeof(WeekDay), day, ignoreCase: true);
                answerLabel.Text = $"«Это день недели ({аnswer} = {(int)аnswer + 1})";
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
            seasonAnswer.Text = string.Empty;
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
            for (int i = 0; i < _countItems; i++)
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
        /// Устанавливает значение выбранного фильма
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = filmsListBox.SelectedIndex;
            Films current = _films[index];
            titleTextBox.Text = current.Title.ToString();
            genreTextBox.Text = current.Genre.ToString();
            durationTextBox.Text = current.Duration.ToString();
            yearOfReleaseTextBox.Text = current.YearOfRelease.ToString();
            ratingTextBox.Text = current.Rating.ToString();
        }

        /// <summary>
        /// Находит фильм с максимальным рейтингом и выбирает его в listbox
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void FindFilmWithMaxRating(object sender, EventArgs e)
        {
            int maxRatingIndex = 0;
            double maxRating = 0d;
            for (int i = 0; i < _countItems; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRatingIndex = i;
                    maxRating = _films[i].Rating;
                }
            }
            filmsListBox.SelectedIndex = maxRatingIndex;
        }


        /// <summary>
        /// Проверяет изменения названия в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void TitleTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = filmsListBox.SelectedIndex;
                _films[index].Title = titleTextBox.Text;
                titleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                titleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения рейтинга в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void RatingTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = filmsListBox.SelectedIndex;
                _films[index].Rating = double.Parse(ratingTextBox.Text);
                ratingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения жанра в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void GenreTextChanged(object sender, EventArgs e)
        {
            bool check = Enum.IsDefined(typeof(Genre), genreTextBox.Text);
            if (check)
            {
                int index = filmsListBox.SelectedIndex;
                _films[index].Genre = genreTextBox.Text;
                genreTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                genreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения года выпуска в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void YearOfReleaseTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = filmsListBox.SelectedIndex;
                _films[index].YearOfRelease = int.Parse(yearOfReleaseTextBox.Text);
                yearOfReleaseTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                yearOfReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Проверяет изменения продолжительности в TextBox.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void DurationTextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = filmsListBox.SelectedIndex;
                _films[index].Duration = int.Parse(durationTextBox.Text);
                durationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                durationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
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
        private void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            //Работа с полями прямоугольника.
            Model.Rectangle currentRectangle = RectangleFactory.Randomize(
                panelForRectangles.Width,
               panelForRectangles.Height);
            _rectangles.Add(currentRectangle);
            string text = CreateStringWithRectangleParameters(
                currentRectangle.Id,
                currentRectangle.Center.X, 
                currentRectangle.Center.Y,
                currentRectangle.Width,
                currentRectangle.Length);
            rectanglesListBox.Items.Insert(_rectangles.Count - 6,text);
            //Работа с панелью.
            Panel currentPanel = new Panel();
            currentPanel.Location = new Point(
                (int)currentRectangle.Center.X, 
                (int)currentRectangle.Center.Y);
            currentPanel.Width = (int)currentRectangle.Width;
            currentPanel.Height = (int)currentRectangle.Length;
            currentPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            panels.Add(currentPanel);
            panelForRectangles.Controls.Add(currentPanel);
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
        private void ButtonRemoveRectangle_Click(object sender, EventArgs e)
        {
            var index = rectanglesListBox.SelectedIndex;
            if (index >= 0)
            {
                _rectangles.RemoveAt(index+5);
                rectanglesListBox.Items.RemoveAt(index);
                panels.RemoveAt(index);
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
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = rectanglesListBox.SelectedIndex;
            if (index < 0)
            {
                ClearRectangleInfo();
            }
            else
            {
                Model.Rectangle currentRectangle = _rectangles[index+5];
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
        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = _rectangles[index + 5];
                if (int.Parse(xTextBox.Text) + currentRectangle.Width <= panelForRectangles.Width)
                {
                    _rectangles[index + 5].Center.X = int.Parse(xTextBox.Text);
                    xTextBox.BackColor = System.Drawing.Color.White;
                    Point point = new Point();
                    point.X = (int)currentRectangle.Center.X;
                    point.Y = (int)currentRectangle.Center.Y;
                    panels[index].Location = point;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    xTextBox.BackColor = System.Drawing.Color.Pink;
                }
            }
            catch 
            {
                xTextBox.BackColor = System.Drawing.Color.Pink;
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
        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = _rectangles[index + 5];
                if (int.Parse(yTextBox.Text) + currentRectangle.Length <= panelForRectangles.Height)
                {
                    _rectangles[index + 5].Center.Y = int.Parse(yTextBox.Text);
                    yTextBox.BackColor = System.Drawing.Color.White;
                    Point point = new Point();
                    point.X = (int)currentRectangle.Center.X;
                    point.Y = (int)currentRectangle.Center.Y;
                    panels[index].Location = point;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    yTextBox.BackColor = System.Drawing.Color.Pink;
                }
            }
            catch
            {
                yTextBox.BackColor = System.Drawing.Color.Pink;
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
        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = _rectangles[index + 5];
                if (int.Parse(widthRectangleTextBox.Text) + currentRectangle.Center.X 
                    <= panelForRectangles.Width)
                {
                    _rectangles[index + 5].Width = double.Parse(widthRectangleTextBox.Text);
                    widthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    panels[index].Width = (int)currentRectangle.Width;
                    ChangingParametersOfRectangle(index, currentRectangle);
                }
                else
                {
                    widthRectangleTextBox.BackColor = System.Drawing.Color.Pink;
                }
            }
            catch
            {
                widthRectangleTextBox.BackColor = System.Drawing.Color.Pink;
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
        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = rectanglesListBox.SelectedIndex;
                Model.Rectangle currentRectangle = _rectangles[index + 5];
                if (int.Parse(lengthRectangleTextBox.Text) + currentRectangle.Center.Y
                    <= panelForRectangles.Height)
                {
                    _rectangles[index + 5].Length = double.Parse(lengthRectangleTextBox.Text);
                    lengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    panels[index].Height = (int)currentRectangle.Length;
                    ChangingParametersOfRectangle(index,currentRectangle);
                }
                else
                {
                    lengthRectangleTextBox.BackColor = System.Drawing.Color.Pink;
                }
            }
            catch
            {
                lengthRectangleTextBox.BackColor = System.Drawing.Color.Pink;
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
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 5; i < _rectangles.Count; i++)
            {
                for (int j = 5; j < _rectangles.Count; j++)
                {
                    if (_rectangles[i] == _rectangles[j])
                    {
                        continue;
                    }
                    else
                    {
                        if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                        {
                            panels[i - 5].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                            panels[j - 5].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
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
