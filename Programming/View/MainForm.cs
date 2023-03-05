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
        public MainForm()
        {
            InitializeComponent();
            var enums = 
            { 
                "Color",
                "EducationForm",
                "Genre",
                "Manufacturers",
                "Season",
                "Weekday"
            };
            EnumsListBox.Items.AddRange(enums);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            IntValues.Text = String.Empty();
            var elementNumber = EnumsListBox.SelectedItem;
            switch (elementNumber)
            {
                case "Color":
                {
                    var values = Enum.GetValues(typeof(Color));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;    
                }
                case "EducationForm":
                {
                    var values = Enum.GetValues(typeof(EducationForm));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Genre":
                {
                    var values = Enum.GetValues(typeof(Genre));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Manufacturer":
                {
                    var values = Enum.GetValues(typeof(Manufacturer));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Season":
                {
                    var values = Enum.GetValues(typeof(Season));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "WeekDay":
                {
                    var values = Enum.GetValues(typeof(WeekDay));
                    foreach (var item in values)
                    {
                        ValuesListBox.Items.Add(item);
                    }
                    break;
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValues.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var day = Days.Text;
            WeekDay seasonCheck;
            var check = Enum.TryParse(day,out seasonCheck);
            if (check)
            {
                WeekDay Answer = (WeekDay) Enum.Parse(typeof(WeekDay), day,ignoreCase: true);
                AnswerLabel.Text = $"«Это день недели ({Answer} = {(int)Answer+1})";
            }
            else
            {
                AnswerLabel.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            SeasonAnswer.Text = String.Empty();
            SeasonHandleBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            switch (SeasonBox.SelectedItem)
            {
                case "Winter":
                {
                        SeasonAnswer.Text = "Бррр! Холодно!";
                        break;
                }
                case "Spring":
                {
                        SeasonHandleBox.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                }
                case "Summer":
                {
                        SeasonAnswer.Text = "Ура! Солнце!";
                        break;
                }
                case "Autumn":
                {
                        SeasonHandleBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                }
                default:
                {
                        SeasonAnswer.Text = "Это не время года";
                        break;
                }
            }
        }
    }
}
