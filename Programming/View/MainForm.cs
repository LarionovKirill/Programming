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
            string[] enums = { "Colour","EducationForm","Genre","Manufactures","Season","Weekday"};
            EnumsListBox.Items.AddRange(enums);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            IntValues.Text = "";
            var ElementNumber = EnumsListBox.SelectedIndex;
            switch (ElementNumber)
            {
                case 0:
                    {
                        var values = Enum.GetValues(typeof(Colour));
                        foreach (var item in values)
                        {
                            ValuesListBox.Items.Add(item);
                        }
                        break;
                    }
                case 1:
                    {
                        var values = Enum.GetValues(typeof(EducationForm));
                        foreach (var item in values)
                        {
                            ValuesListBox.Items.Add(item);
                        }
                        break;
                    }
                case 2:
                    {
                        var values = Enum.GetValues(typeof(Genre));
                        foreach (var item in values)
                        {
                            ValuesListBox.Items.Add(item);
                        }
                        break;
                    }
                case 3:
                    {
                        var values = Enum.GetValues(typeof(Manufactures));
                        foreach (var item in values)
                        {
                            ValuesListBox.Items.Add(item);
                        }
                        break;
                    }
                case 4:
                    {
                        var values = Enum.GetValues(typeof(Season));
                        foreach (var item in values)
                        {
                            ValuesListBox.Items.Add(item);
                        }
                        break;
                    }
                case 5:
                    {
                        var values = Enum.GetValues(typeof(Weekday));
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
            string day = Days.Text;
            Weekday b;
            var Check = Enum.TryParse(day,out b);
            if (Check)
            {
                Weekday Answer = (Weekday) Enum.Parse(typeof(Weekday), day,ignoreCase: true);
                AnswerLabel.Text = $"«Это день недели ({Answer} = {(int)Answer+1})";
            }
            else
            {
                AnswerLabel.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            SeasonAnswer.Text = "";
            SeasonHandleBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            switch (SeasonBox.SelectedIndex)
            {
                case 0:
                    {
                        SeasonAnswer.Text = "Бррр! Холодно!";
                        break;
                    }
                case 1:
                    {
                        SeasonHandleBox.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                    }
                case 2:
                    {
                        SeasonAnswer.Text = "Ура! Солнце!";
                        break;
                    }
                case 3:
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
