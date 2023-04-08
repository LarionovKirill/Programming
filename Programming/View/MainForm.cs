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
    }
}
