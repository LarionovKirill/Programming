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
            Model.Enums.Color color;
            Genre genre;
            int countOfGenre = Enum.GetNames(typeof(Genre)).Length;
            int countOfColors = Enum.GetNames(typeof(Model.Enums.Color)).Length;

            //Заполнение listbox 
            for (int i = 0; i < countItems; i++)
            {
                ///Заполнеение прямоугольников
                _rectangles[i] = new Model.Rectangle();
                rectangleListBox.Items.Add($"Rectangle {i + 1}");
                _rectangles[i].Length = random.Next(1, 51);
                _rectangles[i].Width = random.Next(1, 51);
                color = (Model.Enums.Color)random.Next(countOfColors);
                _rectangles[i].Color = color.ToString();

                //Заполнение фильмов
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
            lengthTextBox.Text = _rectangles[index].Length.ToString();
            widthTextBox.Text = _rectangles[index].Width.ToString();
            colorTextBox.Text = _rectangles[index].Color.ToString();
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
            titleTextBox.Text = _films[index].Title.ToString();
            genreTextBox.Text = _films[index].Genre.ToString();
            durationTextBox.Text = _films[index].Duration.ToString();
            yearOfReleaseTextBox.Text = _films[index].YearOfRelease.ToString();
            ratingTextBox.Text = _films[index].Rating.ToString();
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
                throw new ArgumentException();
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
    }
}
