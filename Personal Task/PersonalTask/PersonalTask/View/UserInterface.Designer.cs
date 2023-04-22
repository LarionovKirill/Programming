
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
            this.departureTimeTextBox = new System.Windows.Forms.TextBox();
            this.typeOfFlightTextBox = new System.Windows.Forms.TextBox();
            this.flightTimeTextBox = new System.Windows.Forms.TextBox();
            this.timeFlightLabel = new System.Windows.Forms.Label();
            this.typeOfFlightLabel = new System.Windows.Forms.Label();
            this.dayOfFlightLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.changePictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.airTravelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
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
            this.airTravelsListBox.SelectedIndexChanged += new System.EventHandler(this.AirTravelsListBox_SelectedIndexChanged);
            // 
            // airTravelGroupBox
            // 
            this.airTravelGroupBox.Controls.Add(this.departureTimeTextBox);
            this.airTravelGroupBox.Controls.Add(this.typeOfFlightTextBox);
            this.airTravelGroupBox.Controls.Add(this.flightTimeTextBox);
            this.airTravelGroupBox.Controls.Add(this.timeFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.typeOfFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.dayOfFlightLabel);
            this.airTravelGroupBox.Controls.Add(this.destinationLabel);
            this.airTravelGroupBox.Controls.Add(this.departureLabel);
            this.airTravelGroupBox.Controls.Add(this.destinationTextBox);
            this.airTravelGroupBox.Controls.Add(this.departureTextBox);
            this.airTravelGroupBox.Location = new System.Drawing.Point(368, 26);
            this.airTravelGroupBox.Name = "airTravelGroupBox";
            this.airTravelGroupBox.Size = new System.Drawing.Size(470, 235);
            this.airTravelGroupBox.TabIndex = 1;
            this.airTravelGroupBox.TabStop = false;
            this.airTravelGroupBox.Text = "Информация о полете";
            // 
            // departureTimeTextBox
            // 
            this.departureTimeTextBox.Location = new System.Drawing.Point(149, 113);
            this.departureTimeTextBox.Name = "departureTimeTextBox";
            this.departureTimeTextBox.ReadOnly = true;
            this.departureTimeTextBox.Size = new System.Drawing.Size(200, 22);
            this.departureTimeTextBox.TabIndex = 9;
            // 
            // typeOfFlightTextBox
            // 
            this.typeOfFlightTextBox.Location = new System.Drawing.Point(149, 151);
            this.typeOfFlightTextBox.Name = "typeOfFlightTextBox";
            this.typeOfFlightTextBox.ReadOnly = true;
            this.typeOfFlightTextBox.Size = new System.Drawing.Size(200, 22);
            this.typeOfFlightTextBox.TabIndex = 5;
            // 
            // flightTimeTextBox
            // 
            this.flightTimeTextBox.Location = new System.Drawing.Point(147, 191);
            this.flightTimeTextBox.Name = "flightTimeTextBox";
            this.flightTimeTextBox.ReadOnly = true;
            this.flightTimeTextBox.Size = new System.Drawing.Size(202, 22);
            this.flightTimeTextBox.TabIndex = 9;
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
            this.dayOfFlightLabel.Size = new System.Drawing.Size(102, 17);
            this.dayOfFlightLabel.TabIndex = 5;
            this.dayOfFlightLabel.Text = "Дата вылета :";
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
            this.destinationTextBox.ReadOnly = true;
            this.destinationTextBox.Size = new System.Drawing.Size(315, 22);
            this.destinationTextBox.TabIndex = 1;
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(149, 35);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.ReadOnly = true;
            this.departureTextBox.Size = new System.Drawing.Size(315, 22);
            this.departureTextBox.TabIndex = 0;
            // 
            // changePictureBox
            // 
            this.changePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changePictureBox.Image")));
            this.changePictureBox.Location = new System.Drawing.Point(70, 491);
            this.changePictureBox.Name = "changePictureBox";
            this.changePictureBox.Size = new System.Drawing.Size(36, 33);
            this.changePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changePictureBox.TabIndex = 4;
            this.changePictureBox.TabStop = false;
            this.changePictureBox.Click += new System.EventHandler(this.ChangePictureBox_Click);
            this.changePictureBox.MouseLeave += new System.EventHandler(this.ChangePictureBox_MouseLeave);
            this.changePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePictureBox_MouseMove);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(122, 491);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(36, 33);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 3;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.Click += new System.EventHandler(this.DeletePictureBox_Click);
            this.deletePictureBox.MouseLeave += new System.EventHandler(this.DeletePictureBox_MouseLeave);
            this.deletePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeletePictureBox_MouseMove);
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
            this.addPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            this.addPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            this.addPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPictureBox_MouseMove);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePictureBox);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.airTravelGroupBox);
            this.Controls.Add(this.airTravelsListBox);
            this.Name = "UserInterface";
            this.Size = new System.Drawing.Size(856, 529);
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.airTravelGroupBox.ResumeLayout(false);
            this.airTravelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox airTravelsListBox;
        private System.Windows.Forms.GroupBox airTravelGroupBox;
        private System.Windows.Forms.TextBox flightTimeTextBox;
        private System.Windows.Forms.Label timeFlightLabel;
        private System.Windows.Forms.Label typeOfFlightLabel;
        private System.Windows.Forms.Label dayOfFlightLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.PictureBox changePictureBox;
        private System.Windows.Forms.TextBox typeOfFlightTextBox;
        private System.Windows.Forms.TextBox departureTimeTextBox;
    }
}
