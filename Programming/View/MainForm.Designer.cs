
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
            this.SeasonHandleBox = new System.Windows.Forms.GroupBox();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.WeekdayParsingBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.Days = new System.Windows.Forms.TextBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.EnumerationsBox = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.Enumaration = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.Label();
            this.IntValues = new System.Windows.Forms.TextBox();
            this.SeasonAnswer = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandleBox.SuspendLayout();
            this.WeekdayParsingBox.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonHandleBox);
            this.Enums.Controls.Add(this.WeekdayParsingBox);
            this.Enums.Controls.Add(this.EnumerationsBox);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(948, 535);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleBox
            // 
            this.SeasonHandleBox.Controls.Add(this.SeasonBox);
            this.SeasonHandleBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleBox.Controls.Add(this.SeasonAnswer);
            this.SeasonHandleBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleBox.Location = new System.Drawing.Point(556, 350);
            this.SeasonHandleBox.Name = "SeasonHandleBox";
            this.SeasonHandleBox.Size = new System.Drawing.Size(349, 153);
            this.SeasonHandleBox.TabIndex = 16;
            this.SeasonHandleBox.TabStop = false;
            this.SeasonHandleBox.Text = "Season Handle";
            // 
            // SeasonBox
            // 
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.SeasonBox.Location = new System.Drawing.Point(6, 60);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(212, 24);
            this.SeasonBox.TabIndex = 10;
            // 
            // WeekdayParsingBox
            // 
            this.WeekdayParsingBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingBox.Controls.Add(this.Days);
            this.WeekdayParsingBox.Controls.Add(this.AnswerLabel);
            this.WeekdayParsingBox.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsingBox.Location = new System.Drawing.Point(29, 350);
            this.WeekdayParsingBox.Name = "WeekdayParsingBox";
            this.WeekdayParsingBox.Size = new System.Drawing.Size(354, 158);
            this.WeekdayParsingBox.TabIndex = 15;
            this.WeekdayParsingBox.TabStop = false;
            this.WeekdayParsingBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(253, 71);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(95, 24);
            this.ParseButton.TabIndex = 8;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(13, 70);
            this.Days.Multiline = true;
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(234, 24);
            this.Days.TabIndex = 6;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(10, 49);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(150, 17);
            this.WeekdayLabel.TabIndex = 7;
            this.WeekdayLabel.Text = "Type value for parsing";
            // 
            // EnumerationsBox
            // 
            this.EnumerationsBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsBox.Controls.Add(this.ChooseValue);
            this.EnumerationsBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsBox.Controls.Add(this.Enumaration);
            this.EnumerationsBox.Controls.Add(this.IntValue);
            this.EnumerationsBox.Controls.Add(this.IntValues);
            this.EnumerationsBox.Location = new System.Drawing.Point(29, 18);
            this.EnumerationsBox.Name = "EnumerationsBox";
            this.EnumerationsBox.Size = new System.Drawing.Size(707, 299);
            this.EnumerationsBox.TabIndex = 14;
            this.EnumerationsBox.TabStop = false;
            this.EnumerationsBox.Text = "Enumerations";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(236, 43);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(157, 132);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ChooseValue
            // 
            this.ChooseValue.AutoSize = true;
            this.ChooseValue.Location = new System.Drawing.Point(240, 18);
            this.ChooseValue.Name = "ChooseValue";
            this.ChooseValue.Size = new System.Drawing.Size(100, 17);
            this.ChooseValue.TabIndex = 4;
            this.ChooseValue.Text = "Choose Value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(26, 43);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(156, 132);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // Enumaration
            // 
            this.Enumaration.AutoSize = true;
            this.Enumaration.Location = new System.Drawing.Point(26, 23);
            this.Enumaration.Name = "Enumaration";
            this.Enumaration.Size = new System.Drawing.Size(143, 17);
            this.Enumaration.TabIndex = 5;
            this.Enumaration.Text = "Choose enumaration:";
            // 
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(491, 23);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(67, 17);
            this.IntValue.TabIndex = 3;
            this.IntValue.Text = "Int Value:";
            // 
            // IntValues
            // 
            this.IntValues.Location = new System.Drawing.Point(494, 43);
            this.IntValues.Multiline = true;
            this.IntValues.Name = "IntValues";
            this.IntValues.Size = new System.Drawing.Size(148, 28);
            this.IntValues.TabIndex = 2;
            // 
            // SeasonAnswer
            // 
            this.SeasonAnswer.AutoSize = true;
            this.SeasonAnswer.Location = new System.Drawing.Point(31, 113);
            this.SeasonAnswer.Name = "SeasonAnswer";
            this.SeasonAnswer.Size = new System.Drawing.Size(0, 17);
            this.SeasonAnswer.TabIndex = 13;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(235, 60);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(91, 23);
            this.SeasonButton.TabIndex = 12;
            this.SeasonButton.Text = "Go";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 40);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 17);
            this.SeasonLabel.TabIndex = 11;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(26, 113);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 17);
            this.AnswerLabel.TabIndex = 9;
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataSource = typeof(Programming.Model.Enums.Weekday);
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
            this.SeasonHandleBox.ResumeLayout(false);
            this.SeasonHandleBox.PerformLayout();
            this.WeekdayParsingBox.ResumeLayout(false);
            this.WeekdayParsingBox.PerformLayout();
            this.EnumerationsBox.ResumeLayout(false);
            this.EnumerationsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.TextBox IntValues;
        private System.Windows.Forms.Label IntValue;
        private System.Windows.Forms.Label Enumaration;
        private System.Windows.Forms.Label ChooseValue;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.BindingSource weekdayBindingSource;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox SeasonBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonAnswer;
        private System.Windows.Forms.GroupBox EnumerationsBox;
        private System.Windows.Forms.GroupBox SeasonHandleBox;
        private System.Windows.Forms.GroupBox WeekdayParsingBox;
    }
}