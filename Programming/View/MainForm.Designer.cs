
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
            this.filmsListControl1 = new Programming.View.Panels.FilmsListControl();
            this.rectangleListControl1 = new Programming.View.Panels.RectangleListControl();
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rectangleListControl2 = new Programming.View.Panels.RectangleListControl();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.seasonHandleBox.SuspendLayout();
            this.weekdayParsingBox.SuspendLayout();
            this.enumerationsBox.SuspendLayout();
            this.classes.SuspendLayout();
            this.Rectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.classes);
            this.tabControl1.Controls.Add(this.Rectangles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 563);
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
            this.Enums.Size = new System.Drawing.Size(948, 534);
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
            this.seasonHandleBox.Location = new System.Drawing.Point(474, 350);
            this.seasonHandleBox.Name = "seasonHandleBox";
            this.seasonHandleBox.Size = new System.Drawing.Size(441, 177);
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
            this.weekdayParsingBox.Size = new System.Drawing.Size(427, 177);
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
            this.enumerationsBox.Size = new System.Drawing.Size(886, 326);
            this.enumerationsBox.TabIndex = 14;
            this.enumerationsBox.TabStop = false;
            this.enumerationsBox.Text = "Enumerations";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 16;
            this.valuesListBox.Location = new System.Drawing.Point(253, 43);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(175, 212);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // chooseValue
            // 
            this.chooseValue.AutoSize = true;
            this.chooseValue.Location = new System.Drawing.Point(250, 23);
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
            this.enumsListBox.Size = new System.Drawing.Size(175, 212);
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
            this.intValue.Location = new System.Drawing.Point(536, 23);
            this.intValue.Name = "intValue";
            this.intValue.Size = new System.Drawing.Size(67, 17);
            this.intValue.TabIndex = 3;
            this.intValue.Text = "Int Value:";
            // 
            // intValues
            // 
            this.intValues.Location = new System.Drawing.Point(539, 43);
            this.intValues.Multiline = true;
            this.intValues.Name = "intValues";
            this.intValues.Size = new System.Drawing.Size(148, 28);
            this.intValues.TabIndex = 2;
            // 
            // classes
            // 
            this.classes.Controls.Add(this.rectangleListControl2);
            this.classes.Controls.Add(this.filmsListControl1);
            this.classes.Controls.Add(this.rectangleListControl1);
            this.classes.Location = new System.Drawing.Point(4, 25);
            this.classes.Name = "classes";
            this.classes.Padding = new System.Windows.Forms.Padding(3);
            this.classes.Size = new System.Drawing.Size(948, 534);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = true;
            // 
            // filmsListControl1
            // 
            this.filmsListControl1.Location = new System.Drawing.Point(476, 31);
            this.filmsListControl1.Name = "filmsListControl1";
            this.filmsListControl1.Size = new System.Drawing.Size(421, 491);
            this.filmsListControl1.TabIndex = 2;
            // 
            // rectangleListControl1
            // 
            this.rectangleListControl1.Location = new System.Drawing.Point(527, 65);
            this.rectangleListControl1.Name = "rectangleListControl1";
            this.rectangleListControl1.Size = new System.Drawing.Size(150, 150);
            this.rectangleListControl1.TabIndex = 1;
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles.Location = new System.Drawing.Point(4, 25);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangles.Size = new System.Drawing.Size(948, 534);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            this.Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, -3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(942, 534);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataSource = typeof(Programming.Model.Enums.WeekDay);
            // 
            // rectangleListControl2
            // 
            this.rectangleListControl2.Location = new System.Drawing.Point(20, 31);
            this.rectangleListControl2.Name = "rectangleListControl2";
            this.rectangleListControl2.Size = new System.Drawing.Size(411, 484);
            this.rectangleListControl2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 563);
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
            this.Rectangles.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Rectangles;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.RectangleListControl rectangleListControl1;
        private Panels.FilmsListControl filmsListControl1;
        private Panels.RectangleListControl rectangleListControl2;
    }
}