
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.airTravelsListBox = new System.Windows.Forms.ListBox();
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
            this.changePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.airTravelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // airTravelsListBox
            // 
            this.airTravelsListBox.FormattingEnabled = true;
            this.airTravelsListBox.ItemHeight = 16;
            this.airTravelsListBox.Location = new System.Drawing.Point(19, 17);
            this.airTravelsListBox.Name = "airTravelsListBox";
            this.airTravelsListBox.Size = new System.Drawing.Size(330, 468);
            this.airTravelsListBox.TabIndex = 0;
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
            this.timeFlightTextBox.Size = new System.Drawing.Size(202, 22);
            this.timeFlightTextBox.TabIndex = 9;
            this.timeFlightTextBox.TextChanged += new System.EventHandler(this.TimeFlightTextBox_TextChanged);
            // 
            // typeOfFlightComboBox
            // 
            this.typeOfFlightComboBox.FormattingEnabled = true;
            this.typeOfFlightComboBox.Location = new System.Drawing.Point(149, 151);
            this.typeOfFlightComboBox.Name = "typeOfFlightComboBox";
            this.typeOfFlightComboBox.Size = new System.Drawing.Size(200, 24);
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
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
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
            this.destinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(149, 35);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(315, 22);
            this.departureTextBox.TabIndex = 0;
            this.departureTextBox.TextChanged += new System.EventHandler(this.DepartureTextBox_TextChanged);
            // 
            // changePictureBox
            // 
            this.changePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changePictureBox.Image")));
            this.changePictureBox.Location = new System.Drawing.Point(121, 491);
            this.changePictureBox.Name = "changePictureBox";
            this.changePictureBox.Size = new System.Drawing.Size(36, 33);
            this.changePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changePictureBox.TabIndex = 4;
            this.changePictureBox.TabStop = false;
            this.changePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePictureBox_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // addPictureBox
            // 
            this.addPictureBox.Image = global::PersonalTask.Properties.Resources.GreenAddButton;
            this.addPictureBox.Location = new System.Drawing.Point(19, 491);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(36, 33);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 2;
            this.addPictureBox.TabStop = false;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.airTravelGroupBox);
            this.Controls.Add(this.airTravelsListBox);
            this.Name = "UserInterface";
            this.Size = new System.Drawing.Size(856, 529);
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.airTravelGroupBox.ResumeLayout(false);
            this.airTravelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox airTravelsListBox;
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
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox changePictureBox;
    }
}
