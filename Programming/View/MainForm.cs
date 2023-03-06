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
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            intValues.Text = String.Empty;
            var elementNumber = enumsListBox.SelectedItem;
            switch (elementNumber)
            {
                case "Color":
                {
                    var values = Enum.GetValues(typeof(Model.Enums.Color));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;    
                }
                case "EducationForm":
                {
                    var values = Enum.GetValues(typeof(EducationForm));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Genre":
                {
                    var values = Enum.GetValues(typeof(Genre));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Manufacturer":
                {
                    var values = Enum.GetValues(typeof(Manufacturer));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "Season":
                {
                    var values = Enum.GetValues(typeof(Season));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;
                }
                case "WeekDay":
                {
                    var values = Enum.GetValues(typeof(WeekDay));
                    foreach (var item in values)
                    {
                        valuesListBox.Items.Add(item);
                    }
                    break;
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValues.Text = valuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var day = days.Text;
            WeekDay seasonCheck;
            var check = Enum.TryParse(day,out seasonCheck);
            if (check)
            {
                WeekDay answer = (WeekDay) Enum.Parse(typeof(WeekDay), day,ignoreCase: true);
                answerLabel.Text = $"«Это день недели ({answer} = {(int)answer+1})";
            }
            else
            {
                answerLabel.Text = "Нет такого дня недели";
            }
        }

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
    }
}
