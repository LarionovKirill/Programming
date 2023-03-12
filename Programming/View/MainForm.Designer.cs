﻿
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
            this.Classes = new System.Windows.Forms.TabPage();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectanglesButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FimsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.seasonHandleBox.SuspendLayout();
            this.weekdayParsingBox.SuspendLayout();
            this.enumerationsBox.SuspendLayout();
            this.Classes.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.Classes);
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
            // Classes
            // 
            this.Classes.Controls.Add(this.FilmsGroupBox);
            this.Classes.Controls.Add(this.RectangleGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 25);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(948, 535);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.FindRectanglesButton);
            this.RectangleGroupBox.Controls.Add(this.ColorLabel);
            this.RectangleGroupBox.Controls.Add(this.WidthLabel);
            this.RectangleGroupBox.Controls.Add(this.LengthLabel);
            this.RectangleGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangleGroupBox.Controls.Add(this.WidthTextBox);
            this.RectangleGroupBox.Controls.Add(this.LengthTextBox);
            this.RectangleGroupBox.Controls.Add(this.RectangleListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(28, 31);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(411, 324);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // FindRectanglesButton
            // 
            this.FindRectanglesButton.Location = new System.Drawing.Point(232, 280);
            this.FindRectanglesButton.Name = "FindRectanglesButton";
            this.FindRectanglesButton.Size = new System.Drawing.Size(112, 26);
            this.FindRectanglesButton.TabIndex = 7;
            this.FindRectanglesButton.Text = "Find";
            this.FindRectanglesButton.UseVisualStyleBackColor = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(231, 191);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 17);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(229, 114);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(229, 38);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(56, 17);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(232, 211);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(112, 22);
            this.ColorTextBox.TabIndex = 3;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(232, 134);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(112, 22);
            this.WidthTextBox.TabIndex = 2;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(232, 58);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(112, 22);
            this.LengthTextBox.TabIndex = 1;
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 16;
            this.RectangleListBox.Location = new System.Drawing.Point(19, 30);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(190, 276);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataSource = typeof(Programming.Model.Enums.WeekDay);
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FimsListBox);
            this.FilmsGroupBox.Location = new System.Drawing.Point(472, 32);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(411, 323);
            this.FilmsGroupBox.TabIndex = 1;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FimsListBox
            // 
            this.FimsListBox.FormattingEnabled = true;
            this.FimsListBox.ItemHeight = 16;
            this.FimsListBox.Location = new System.Drawing.Point(22, 29);
            this.FimsListBox.Name = "FimsListBox";
            this.FimsListBox.Size = new System.Drawing.Size(189, 276);
            this.FimsListBox.TabIndex = 2;
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
            this.Classes.ResumeLayout(false);
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).EndInit();
            this.FilmsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Button FindRectanglesButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.ListBox FimsListBox;
    }
}