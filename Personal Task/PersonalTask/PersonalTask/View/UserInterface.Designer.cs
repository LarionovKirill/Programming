
namespace PersonalTask.View
{
    partial class UserInterface
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.airTravelGroupBox = new System.Windows.Forms.GroupBox();
            this.timeFlightTextBox = new System.Windows.Forms.TextBox();
            this.typeOfFlightComboBox = new System.Windows.Forms.ComboBox();
            this.timeFlightLabel = new System.Windows.Forms.Label();
            this.typeOfFlightLabel = new System.Windows.Forms.Label();
            this.dayOfFlightLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.airTravelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(19, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 468);
            this.listBox1.TabIndex = 0;
            // 
            // airTravelGroupBox
            // 
            this.airTravelGroupBox.Controls.Add(this.timeFlightTextBox);
            this.airTravelGroupBox.Controls.Add(this.typeOfFlightComboBox);
            this.airTravelGroupBox.Controls.Add(this.timeFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.typeOfFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.dayOfFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.dateTimePicker);
            this.airTravelGroupBox.Controls.Add(this.destinationLabel);
            this.airTravelGroupBox.Controls.Add(this.departureLabel);
            this.airTravelGroupBox.Controls.Add(this.destinationTextBox);
            this.airTravelGroupBox.Controls.Add(this.departureTextBox);
            this.airTravelGroupBox.Location = new System.Drawing.Point(368, 26);
            this.airTravelGroupBox.Name = "airTravelGroupBox";
            this.airTravelGroupBox.Size = new System.Drawing.Size(470, 235);
            this.airTravelGroupBox.TabIndex = 1;
            this.airTravelGroupBox.TabStop = false;
            this.airTravelGroupBox.Text = "Выбранный полет";
            // 
            // timeFlightTextBox
            // 
            this.timeFlightTextBox.Location = new System.Drawing.Point(147, 191);
            this.timeFlightTextBox.Name = "timeFlightTextBox";
            this.timeFlightTextBox.Size = new System.Drawing.Size(123, 22);
            this.timeFlightTextBox.TabIndex = 9;
            // 
            // typeOfFlightComboBox
            // 
            this.typeOfFlightComboBox.FormattingEnabled = true;
            this.typeOfFlightComboBox.Location = new System.Drawing.Point(149, 151);
            this.typeOfFlightComboBox.Name = "typeOfFlightComboBox";
            this.typeOfFlightComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeOfFlightComboBox.TabIndex = 8;
            // 
            // timeFlightLabel
            // 
            this.timeFlightLabel.AutoSize = true;
            this.timeFlightLabel.Location = new System.Drawing.Point(23, 191);
            this.timeFlightLabel.Name = "timeFlightLabel";
            this.timeFlightLabel.Size = new System.Drawing.Size(120, 17);
            this.timeFlightLabel.TabIndex = 7;
            this.timeFlightLabel.Text = "Время в полете :";
            // 
            // typeOfFlightLabel
            // 
            this.typeOfFlightLabel.AutoSize = true;
            this.typeOfFlightLabel.Location = new System.Drawing.Point(35, 151);
            this.typeOfFlightLabel.Name = "typeOfFlightLabel";
            this.typeOfFlightLabel.Size = new System.Drawing.Size(108, 17);
            this.typeOfFlightLabel.TabIndex = 6;
            this.typeOfFlightLabel.Text = "Тип перелета :";
            // 
            // dayOfFlightLabel
            // 
            this.dayOfFlightLabel.AutoSize = true;
            this.dayOfFlightLabel.Location = new System.Drawing.Point(33, 113);
            this.dayOfFlightLabel.Name = "dayOfFlightLabel";
            this.dayOfFlightLabel.Size = new System.Drawing.Size(110, 17);
            this.dayOfFlightLabel.TabIndex = 5;
            this.dayOfFlightLabel.Text = "Время вылета :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(149, 113);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(5, 74);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(138, 17);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "Пункт назначения :";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Location = new System.Drawing.Point(-2, 35);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(145, 17);
            this.departureLabel.TabIndex = 2;
            this.departureLabel.Text = "Пункт отправления :";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(149, 74);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(315, 22);
            this.destinationTextBox.TabIndex = 1;
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(149, 35);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(315, 22);
            this.departureTextBox.TabIndex = 0;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.airTravelGroupBox);
            this.Controls.Add(this.listBox1);
            this.Name = "UserInterface";
            this.Size = new System.Drawing.Size(856, 529);
            this.airTravelGroupBox.ResumeLayout(false);
            this.airTravelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox airTravelGroupBox;
        private System.Windows.Forms.TextBox timeFlightTextBox;
        private System.Windows.Forms.ComboBox typeOfFlightComboBox;
        private System.Windows.Forms.Label timeFlightLabel;
        private System.Windows.Forms.Label typeOfFlightLabel;
        private System.Windows.Forms.Label dayOfFlightLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
    }
}
