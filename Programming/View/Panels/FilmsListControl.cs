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

namespace Programming.View.Panels
{
    public partial class FilmsListControl : UserControl
    {
        /// <summary>
        /// Массив элементов класса Film.
        /// </summary>
        Model.Films[] _films = new Model.Films[5];

        public FilmsListControl()
        {
            InitializeComponent();
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
            Model.Films current = _films[index];
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
            for (int i = 0; i < 5; i++)
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
                titleTextBox.BackColor = Model.AppColors.correctAnswer;
            }
            catch
            {
                titleTextBox.BackColor = Model.AppColors.wrongAnswer;
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
                ratingTextBox.BackColor = Model.AppColors.correctAnswer;
            }
            catch
            {
                ratingTextBox.BackColor = Model.AppColors.wrongAnswer;
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
                genreTextBox.BackColor = Model.AppColors.correctAnswer;
            }
            else
            {
                genreTextBox.BackColor = Model.AppColors.wrongAnswer;
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
                yearOfReleaseTextBox.BackColor = Model.AppColors.correctAnswer;
            }
            catch
            {
                yearOfReleaseTextBox.BackColor = Model.AppColors.wrongAnswer;
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
                durationTextBox.BackColor = Model.AppColors.correctAnswer;
            }
            catch
            {
                durationTextBox.BackColor = Model.AppColors.wrongAnswer;
            }
        }

        /// <summary>
        /// Метод запускается при запуске интерфейса фильмов и заполняет их в этот момент.
        /// </summary>
        /// <param name="sender">
        /// Предоставляет ссылку на объект, вызвавший событие. 
        /// </param>
        /// <param name="e">
        /// Передает объект, относящийся к обрабатываемому событию.
        /// </param>
        private void FilmsListControl_Load(object sender, EventArgs e)
        {
            int countOfGenre = Enum.GetNames(typeof(Model.Enums.Genre)).Length;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                //Заполнение фильмов
                Genre genre;
                _films[i] = new Model.Films();
                filmsListBox.Items.Add($"Film {i + 1}");
                _films[i].YearOfRelease = random.Next(1900, 2024);
                genre = (Genre)random.Next(countOfGenre);
                _films[i].Genre = genre.ToString();
                _films[i].Rating = random.Next(1, 101) / 10d;
                _films[i].Duration = random.Next(80, 300);
                _films[i].Title = Convert.ToChar(random.Next((int)'A', (int)'Z')).ToString();
            }
            filmsListBox.SelectedIndex = 0;
        }
    }
}
