
namespace PersonalTask.View
{
    partial class ChangingForm
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
            this.agreeButton = new System.Windows.Forms.Button();
            this.flightTimeTextBox = new System.Windows.Forms.TextBox();
            this.typeOfFlightComboBox = new System.Windows.Forms.ComboBox();
            this.timeFlightLabel = new System.Windows.Forms.Label();
            this.typeOfFlightLabel = new System.Windows.Forms.Label();
            this.dayOfFlightLabel = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agreeButton
            // 
            this.agreeButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.agreeButton.Location = new System.Drawing.Point(31, 228);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(128, 45);
            this.agreeButton.TabIndex = 1;
            this.agreeButton.Text = "Сохранить изменения";
            this.agreeButton.UseVisualStyleBackColor = true;
            // 
            // flightTimeTextBox
            // 
            this.flightTimeTextBox.Location = new System.Drawing.Point(177, 174);
            this.flightTimeTextBox.Name = "flightTimeTextBox";
            this.flightTimeTextBox.Size = new System.Drawing.Size(202, 22);
            this.flightTimeTextBox.TabIndex = 19;
            this.flightTimeTextBox.TextChanged += new System.EventHandler(this.TimeFlightTextBox_TextChanged);
            // 
            // typeOfFlightComboBox
            // 
            this.typeOfFlightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfFlightComboBox.FormattingEnabled = true;
            this.typeOfFlightComboBox.Location = new System.Drawing.Point(179, 134);
            this.typeOfFlightComboBox.Name = "typeOfFlightComboBox";
            this.typeOfFlightComboBox.Size = new System.Drawing.Size(200, 24);
            this.typeOfFlightComboBox.TabIndex = 18;
            // 
            // timeFlightLabel
            // 
            this.timeFlightLabel.AutoSize = true;
            this.timeFlightLabel.Location = new System.Drawing.Point(53, 174);
            this.timeFlightLabel.Name = "timeFlightLabel";
            this.timeFlightLabel.Size = new System.Drawing.Size(120, 17);
            this.timeFlightLabel.TabIndex = 17;
            this.timeFlightLabel.Text = "Время в полете :";
            // 
            // typeOfFlightLabel
            // 
            this.typeOfFlightLabel.AutoSize = true;
            this.typeOfFlightLabel.Location = new System.Drawing.Point(65, 134);
            this.typeOfFlightLabel.Name = "typeOfFlightLabel";
            this.typeOfFlightLabel.Size = new System.Drawing.Size(108, 17);
            this.typeOfFlightLabel.TabIndex = 16;
            this.typeOfFlightLabel.Text = "Тип перелета :";
            // 
            // dayOfFlightLabel
            // 
            this.dayOfFlightLabel.AutoSize = true;
            this.dayOfFlightLabel.Location = new System.Drawing.Point(63, 96);
            this.dayOfFlightLabel.Name = "dayOfFlightLabel";
            this.dayOfFlightLabel.Size = new System.Drawing.Size(102, 17);
            this.dayOfFlightLabel.TabIndex = 15;
            this.dayOfFlightLabel.Text = "Дата вылета :";
            // 
            // departureTime
            // 
            this.departureTime.Location = new System.Drawing.Point(179, 96);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(200, 22);
            this.departureTime.TabIndex = 14;
            this.departureTime.ValueChanged += new System.EventHandler(this.DepartureTime_ValueChanged);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(35, 57);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(138, 17);
            this.destinationLabel.TabIndex = 13;
            this.destinationLabel.Text = "Пункт назначения :";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Location = new System.Drawing.Point(28, 18);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(145, 17);
            this.departureLabel.TabIndex = 12;
            this.departureLabel.Text = "Пункт отправления :";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(179, 57);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(315, 22);
            this.destinationTextBox.TabIndex = 11;
            this.destinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(179, 18);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(315, 22);
            this.departureTextBox.TabIndex = 10;
            this.departureTextBox.TextChanged += new System.EventHandler(this.DepartureTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cancelButton.Location = new System.Drawing.Point(382, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 44);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Не сохранять изменения";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ChangingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.flightTimeTextBox);
            this.Controls.Add(this.typeOfFlightComboBox);
            this.Controls.Add(this.timeFlightLabel);
            this.Controls.Add(this.typeOfFlightLabel);
            this.Controls.Add(this.dayOfFlightLabel);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(this.agreeButton);
            this.Name = "ChangingForm";
            this.Text = "ChangingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button agreeButton;
        internal System.Windows.Forms.TextBox flightTimeTextBox;
        internal System.Windows.Forms.ComboBox typeOfFlightComboBox;
        private System.Windows.Forms.Label timeFlightLabel;
        private System.Windows.Forms.Label typeOfFlightLabel;
        private System.Windows.Forms.Label dayOfFlightLabel;
        internal System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label departureLabel;
        internal System.Windows.Forms.TextBox destinationTextBox;
        internal System.Windows.Forms.TextBox departureTextBox;
        internal System.Windows.Forms.Button cancelButton;
    }
}