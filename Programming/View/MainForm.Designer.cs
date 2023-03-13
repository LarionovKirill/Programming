
namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.seasonHandleBox = new System.Windows.Forms.GroupBox();
            this.seasonBox = new System.Windows.Forms.ComboBox();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.seasonAnswer = new System.Windows.Forms.Label();
            this.seasonButton = new System.Windows.Forms.Button();
            this.weekdayParsingBox = new System.Windows.Forms.GroupBox();
            this.parseDaysButton = new System.Windows.Forms.Button();
            this.days = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.weekdayLabel = new System.Windows.Forms.Label();
            this.enumerationsBox = new System.Windows.Forms.GroupBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.chooseValue = new System.Windows.Forms.Label();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.enumaration = new System.Windows.Forms.Label();
            this.intValue = new System.Windows.Forms.Label();
            this.intValues = new System.Windows.Forms.TextBox();
            this.classes = new System.Windows.Forms.TabPage();
            this.filmsGroupBox = new System.Windows.Forms.GroupBox();
            this.findFilmsButton = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearOfRealeseLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.yearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.filmsListBox = new System.Windows.Forms.ListBox();
            this.rectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.findRectanglesButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.rectangleListBox = new System.Windows.Forms.ListBox();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.seasonHandleBox.SuspendLayout();
            this.weekdayParsingBox.SuspendLayout();
            this.enumerationsBox.SuspendLayout();
            this.classes.SuspendLayout();
            this.filmsGroupBox.SuspendLayout();
            this.rectangleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.classes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.seasonHandleBox);
            this.Enums.Controls.Add(this.weekdayParsingBox);
            this.Enums.Controls.Add(this.enumerationsBox);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(948, 535);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // seasonHandleBox
            // 
            this.seasonHandleBox.Controls.Add(this.seasonBox);
            this.seasonHandleBox.Controls.Add(this.seasonLabel);
            this.seasonHandleBox.Controls.Add(this.seasonAnswer);
            this.seasonHandleBox.Controls.Add(this.seasonButton);
            this.seasonHandleBox.Location = new System.Drawing.Point(556, 350);
            this.seasonHandleBox.Name = "seasonHandleBox";
            this.seasonHandleBox.Size = new System.Drawing.Size(349, 153);
            this.seasonHandleBox.TabIndex = 16;
            this.seasonHandleBox.TabStop = false;
            this.seasonHandleBox.Text = "Season Handle";
            // 
            // seasonBox
            // 
            this.seasonBox.FormattingEnabled = true;
            this.seasonBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.seasonBox.Location = new System.Drawing.Point(6, 60);
            this.seasonBox.Name = "seasonBox";
            this.seasonBox.Size = new System.Drawing.Size(212, 24);
            this.seasonBox.TabIndex = 10;
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Location = new System.Drawing.Point(6, 40);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(110, 17);
            this.seasonLabel.TabIndex = 11;
            this.seasonLabel.Text = "Choose season:";
            // 
            // seasonAnswer
            // 
            this.seasonAnswer.AutoSize = true;
            this.seasonAnswer.Location = new System.Drawing.Point(31, 113);
            this.seasonAnswer.Name = "seasonAnswer";
            this.seasonAnswer.Size = new System.Drawing.Size(0, 17);
            this.seasonAnswer.TabIndex = 13;
            // 
            // seasonButton
            // 
            this.seasonButton.Location = new System.Drawing.Point(235, 60);
            this.seasonButton.Name = "seasonButton";
            this.seasonButton.Size = new System.Drawing.Size(91, 23);
            this.seasonButton.TabIndex = 12;
            this.seasonButton.Text = "Go";
            this.seasonButton.UseVisualStyleBackColor = true;
            this.seasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // weekdayParsingBox
            // 
            this.weekdayParsingBox.Controls.Add(this.parseDaysButton);
            this.weekdayParsingBox.Controls.Add(this.days);
            this.weekdayParsingBox.Controls.Add(this.answerLabel);
            this.weekdayParsingBox.Controls.Add(this.weekdayLabel);
            this.weekdayParsingBox.Location = new System.Drawing.Point(29, 350);
            this.weekdayParsingBox.Name = "weekdayParsingBox";
            this.weekdayParsingBox.Size = new System.Drawing.Size(354, 158);
            this.weekdayParsingBox.TabIndex = 15;
            this.weekdayParsingBox.TabStop = false;
            this.weekdayParsingBox.Text = "Weekday Parsing";
            // 
            // parseDaysButton
            // 
            this.parseDaysButton.Location = new System.Drawing.Point(253, 71);
            this.parseDaysButton.Name = "parseDaysButton";
            this.parseDaysButton.Size = new System.Drawing.Size(95, 24);
            this.parseDaysButton.TabIndex = 8;
            this.parseDaysButton.Text = "Parse";
            this.parseDaysButton.UseVisualStyleBackColor = true;
            this.parseDaysButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(13, 70);
            this.days.Multiline = true;
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(234, 24);
            this.days.TabIndex = 6;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(26, 113);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 17);
            this.answerLabel.TabIndex = 9;
            // 
            // weekdayLabel
            // 
            this.weekdayLabel.AutoSize = true;
            this.weekdayLabel.Location = new System.Drawing.Point(10, 49);
            this.weekdayLabel.Name = "weekdayLabel";
            this.weekdayLabel.Size = new System.Drawing.Size(150, 17);
            this.weekdayLabel.TabIndex = 7;
            this.weekdayLabel.Text = "Type value for parsing";
            // 
            // enumerationsBox
            // 
            this.enumerationsBox.Controls.Add(this.valuesListBox);
            this.enumerationsBox.Controls.Add(this.chooseValue);
            this.enumerationsBox.Controls.Add(this.enumsListBox);
            this.enumerationsBox.Controls.Add(this.enumaration);
            this.enumerationsBox.Controls.Add(this.intValue);
            this.enumerationsBox.Controls.Add(this.intValues);
            this.enumerationsBox.Location = new System.Drawing.Point(29, 18);
            this.enumerationsBox.Name = "enumerationsBox";
            this.enumerationsBox.Size = new System.Drawing.Size(707, 299);
            this.enumerationsBox.TabIndex = 14;
            this.enumerationsBox.TabStop = false;
            this.enumerationsBox.Text = "Enumerations";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 16;
            this.valuesListBox.Location = new System.Drawing.Point(236, 43);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(157, 132);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // chooseValue
            // 
            this.chooseValue.AutoSize = true;
            this.chooseValue.Location = new System.Drawing.Point(233, 23);
            this.chooseValue.Name = "chooseValue";
            this.chooseValue.Size = new System.Drawing.Size(100, 17);
            this.chooseValue.TabIndex = 4;
            this.chooseValue.Text = "Choose Value:";
            // 
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.ItemHeight = 16;
            this.enumsListBox.Location = new System.Drawing.Point(26, 43);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(156, 132);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // enumaration
            // 
            this.enumaration.AutoSize = true;
            this.enumaration.Location = new System.Drawing.Point(26, 23);
            this.enumaration.Name = "enumaration";
            this.enumaration.Size = new System.Drawing.Size(143, 17);
            this.enumaration.TabIndex = 5;
            this.enumaration.Text = "Choose enumaration:";
            // 
            // intValue
            // 
            this.intValue.AutoSize = true;
            this.intValue.Location = new System.Drawing.Point(491, 23);
            this.intValue.Name = "intValue";
            this.intValue.Size = new System.Drawing.Size(67, 17);
            this.intValue.TabIndex = 3;
            this.intValue.Text = "Int Value:";
            // 
            // intValues
            // 
            this.intValues.Location = new System.Drawing.Point(494, 43);
            this.intValues.Multiline = true;
            this.intValues.Name = "intValues";
            this.intValues.Size = new System.Drawing.Size(148, 28);
            this.intValues.TabIndex = 2;
            // 
            // classes
            // 
            this.classes.Controls.Add(this.filmsGroupBox);
            this.classes.Controls.Add(this.rectangleGroupBox);
            this.classes.Location = new System.Drawing.Point(4, 25);
            this.classes.Name = "classes";
            this.classes.Padding = new System.Windows.Forms.Padding(3);
            this.classes.Size = new System.Drawing.Size(948, 535);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = true;
            // 
            // filmsGroupBox
            // 
            this.filmsGroupBox.Controls.Add(this.findFilmsButton);
            this.filmsGroupBox.Controls.Add(this.ratingLabel);
            this.filmsGroupBox.Controls.Add(this.ratingTextBox);
            this.filmsGroupBox.Controls.Add(this.genreLabel);
            this.filmsGroupBox.Controls.Add(this.yearOfRealeseLabel);
            this.filmsGroupBox.Controls.Add(this.durationLabel);
            this.filmsGroupBox.Controls.Add(this.titleLabel);
            this.filmsGroupBox.Controls.Add(this.genreTextBox);
            this.filmsGroupBox.Controls.Add(this.yearOfReleaseTextBox);
            this.filmsGroupBox.Controls.Add(this.durationTextBox);
            this.filmsGroupBox.Controls.Add(this.titleTextBox);
            this.filmsGroupBox.Controls.Add(this.filmsListBox);
            this.filmsGroupBox.Location = new System.Drawing.Point(472, 32);
            this.filmsGroupBox.Name = "filmsGroupBox";
            this.filmsGroupBox.Size = new System.Drawing.Size(411, 446);
            this.filmsGroupBox.TabIndex = 1;
            this.filmsGroupBox.TabStop = false;
            this.filmsGroupBox.Text = "Films";
            // 
            // findFilmsButton
            // 
            this.findFilmsButton.Location = new System.Drawing.Point(238, 391);
            this.findFilmsButton.Name = "findFilmsButton";
            this.findFilmsButton.Size = new System.Drawing.Size(112, 26);
            this.findFilmsButton.TabIndex = 13;
            this.findFilmsButton.Text = "Find";
            this.findFilmsButton.UseVisualStyleBackColor = true;
            this.findFilmsButton.Click += new System.EventHandler(this.FindFilmWithMaxRating);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(235, 308);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingLabel.TabIndex = 12;
            this.ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(238, 328);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(112, 22);
            this.ratingTextBox.TabIndex = 11;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextChanged);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(235, 234);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            // 
            // yearOfRealeseLabel
            // 
            this.yearOfRealeseLabel.AutoSize = true;
            this.yearOfRealeseLabel.Location = new System.Drawing.Point(235, 164);
            this.yearOfRealeseLabel.Name = "yearOfRealeseLabel";
            this.yearOfRealeseLabel.Size = new System.Drawing.Size(114, 17);
            this.yearOfRealeseLabel.TabIndex = 9;
            this.yearOfRealeseLabel.Text = "Year of Release:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(235, 92);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(66, 17);
            this.durationLabel.TabIndex = 8;
            this.durationLabel.Text = "Duration:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(235, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(238, 254);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(112, 22);
            this.genreTextBox.TabIndex = 6;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextChanged);
            // 
            // yearOfReleaseTextBox
            // 
            this.yearOfReleaseTextBox.Location = new System.Drawing.Point(238, 184);
            this.yearOfReleaseTextBox.Name = "yearOfReleaseTextBox";
            this.yearOfReleaseTextBox.Size = new System.Drawing.Size(112, 22);
            this.yearOfReleaseTextBox.TabIndex = 5;
            this.yearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextChanged);
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(238, 112);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(112, 22);
            this.durationTextBox.TabIndex = 4;
            this.durationTextBox.TextChanged += new System.EventHandler(this.DurationTextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(238, 47);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(112, 22);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextChanged);
            // 
            // filmsListBox
            // 
            this.filmsListBox.FormattingEnabled = true;
            this.filmsListBox.ItemHeight = 16;
            this.filmsListBox.Location = new System.Drawing.Point(22, 29);
            this.filmsListBox.Name = "filmsListBox";
            this.filmsListBox.Size = new System.Drawing.Size(189, 388);
            this.filmsListBox.TabIndex = 2;
            this.filmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // rectangleGroupBox
            // 
            this.rectangleGroupBox.Controls.Add(this.findRectanglesButton);
            this.rectangleGroupBox.Controls.Add(this.colorLabel);
            this.rectangleGroupBox.Controls.Add(this.widthLabel);
            this.rectangleGroupBox.Controls.Add(this.lengthLabel);
            this.rectangleGroupBox.Controls.Add(this.colorTextBox);
            this.rectangleGroupBox.Controls.Add(this.widthTextBox);
            this.rectangleGroupBox.Controls.Add(this.lengthTextBox);
            this.rectangleGroupBox.Controls.Add(this.rectangleListBox);
            this.rectangleGroupBox.Location = new System.Drawing.Point(28, 31);
            this.rectangleGroupBox.Name = "rectangleGroupBox";
            this.rectangleGroupBox.Size = new System.Drawing.Size(411, 447);
            this.rectangleGroupBox.TabIndex = 0;
            this.rectangleGroupBox.TabStop = false;
            this.rectangleGroupBox.Text = "Rectangles";
            // 
            // findRectanglesButton
            // 
            this.findRectanglesButton.Location = new System.Drawing.Point(232, 392);
            this.findRectanglesButton.Name = "findRectanglesButton";
            this.findRectanglesButton.Size = new System.Drawing.Size(112, 26);
            this.findRectanglesButton.TabIndex = 7;
            this.findRectanglesButton.Text = "Find";
            this.findRectanglesButton.UseVisualStyleBackColor = true;
            this.findRectanglesButton.Click += new System.EventHandler(this.FindRectangleWithMaxWidth);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(231, 165);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 17);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(229, 93);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(229, 28);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(232, 185);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(112, 22);
            this.colorTextBox.TabIndex = 3;
            this.colorTextBox.TextChanged += new System.EventHandler(this.ColorTextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(232, 113);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(112, 22);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextChanged);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(232, 48);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(112, 22);
            this.lengthTextBox.TabIndex = 1;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextChanged);
            // 
            // rectangleListBox
            // 
            this.rectangleListBox.FormattingEnabled = true;
            this.rectangleListBox.ItemHeight = 16;
            this.rectangleListBox.Location = new System.Drawing.Point(19, 30);
            this.rectangleListBox.Name = "rectangleListBox";
            this.rectangleListBox.Size = new System.Drawing.Size(190, 388);
            this.rectangleListBox.TabIndex = 0;
            this.rectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataSource = typeof(Programming.Model.Enums.WeekDay);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.seasonHandleBox.ResumeLayout(false);
            this.seasonHandleBox.PerformLayout();
            this.weekdayParsingBox.ResumeLayout(false);
            this.weekdayParsingBox.PerformLayout();
            this.enumerationsBox.ResumeLayout(false);
            this.enumerationsBox.PerformLayout();
            this.classes.ResumeLayout(false);
            this.filmsGroupBox.ResumeLayout(false);
            this.filmsGroupBox.PerformLayout();
            this.rectangleGroupBox.ResumeLayout(false);
            this.rectangleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.TextBox intValues;
        private System.Windows.Forms.Label intValue;
        private System.Windows.Forms.Label enumaration;
        private System.Windows.Forms.Label chooseValue;
        private System.Windows.Forms.Button parseDaysButton;
        private System.Windows.Forms.Label weekdayLabel;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.BindingSource weekdayBindingSource;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.ComboBox seasonBox;
        private System.Windows.Forms.Button seasonButton;
        private System.Windows.Forms.Label seasonAnswer;
        private System.Windows.Forms.GroupBox enumerationsBox;
        private System.Windows.Forms.GroupBox seasonHandleBox;
        private System.Windows.Forms.GroupBox weekdayParsingBox;
        private System.Windows.Forms.TabPage classes;
        private System.Windows.Forms.GroupBox rectangleGroupBox;
        private System.Windows.Forms.ListBox rectangleListBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Button findRectanglesButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.GroupBox filmsGroupBox;
        private System.Windows.Forms.ListBox filmsListBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox yearOfReleaseTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearOfRealeseLabel;
        private System.Windows.Forms.Button findFilmsButton;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
    }
}