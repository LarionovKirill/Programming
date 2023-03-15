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
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        const int countItems = 5;
        Model.Rectangle[] _rectangles = new Model.Rectangle[countItems];
        Films[] _films = new Films[countItems];

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
            enumsListBox.SelectedIndex = 0;
            Model.Enums.Color color;
            Genre genre;
            int countOfGenre = Enum.GetNames(typeof(Genre)).Length;
            int countOfColors = Enum.GetNames(typeof(Model.Enums.Color)).Length;
           
            //Заполнение listbox 
            for (int i = 0; i < countItems; i++)
            {
                ///Заполнеение прямоугольников
                _rectangles[i] = new Model.Rectangle();
                rectangleListBox.Items.Add($"Rectangle {i+1}");
                _rectangles[i].length = random.Next(1,51);
                _rectangles[i].width = random.Next(1, 51);
                color = (Model.Enums.Color)random.Next(countOfColors);
                _rectangles[i].color = color.ToString();

                //Заполнение фильмов
                _films[i] = new Films();
                filmsListBox.Items.Add($"Film {i + 1}");
                _films[i].yearOfRelease = random.Next(1900, 2024);
                genre = (Genre)random.Next(countOfGenre);
                _films[i].genre = genre.ToString();
                _films[i].rating = random.Next(1, 11) * GetDouble();
                _films[i].duration = random.Next(80, 300);
                _films[i].title = Convert.ToChar(random.Next(65, 133)).ToString();
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
            intValues.Text = string.Empty;
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
                WeekDay аnswer = (WeekDay) Enum.Parse(typeof(WeekDay), day,ignoreCase: true);
                answerLabel.Text = $"«Это день недели ({аnswer} = {(int)аnswer+1})";
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
            lengthTextBox.Text = _rectangles[index].length.ToString();
            widthTextBox.Text = _rectangles[index].width.ToString();
            colorTextBox.Text = _rectangles[index].color.ToString();
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
                if (_rectangles[i].width > maxWidth)
                {
                    maxRectanlgeIndex = i;
                    maxWidth = _rectangles[i].width;
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
                _rectangles[index].length = double.Parse(lengthTextBox.Text);
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
                _rectangles[index].width = double.Parse(widthTextBox.Text);
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
            try
            {
                bool check = Enum.IsDefined(typeof(Model.Enums.Color),colorTextBox.Text);
                if (check)
                {
                    int index = rectangleListBox.SelectedIndex;
                    _rectangles[index].color = colorTextBox.Text;
                    colorTextBox.BackColor = System.Drawing.Color.White;
                }
                else 
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                colorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Возвращает случайное значение от 0,1 до 1
        /// </summary>
        /// <returns></returns>
        double GetDouble()
        {
            return random.Next(1, 11) / 10d;
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
            titleTextBox.Text = _films[index].title.ToString();
            genreTextBox.Text = _films[index].genre.ToString();
            durationTextBox.Text = _films[index].duration.ToString();
            yearOfReleaseTextBox.Text = _films[index].yearOfRelease.ToString();
            ratingTextBox.Text = _films[index].rating.ToString();
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
            for (int i = 0; i < countItems; i++)
            {
                if (_films[i].rating > maxRating)
                {
                    maxRatingIndex = i;
                    maxRating = _films[i].rating;
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
                _films[index].title = titleTextBox.Text;
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
                _films[index].rating = double.Parse(ratingTextBox.Text);
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
            try
            {
                bool check = Enum.IsDefined(typeof(Genre), genreTextBox.Text);
                if (check)
                {
                    int index = filmsListBox.SelectedIndex;
                    _films[index].genre = genreTextBox.Text;
                    genreTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch
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
                _films[index].yearOfRelease = int.Parse(yearOfReleaseTextBox.Text);
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
                _films[index].duration = int.Parse(durationTextBox.Text);
                durationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                durationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
