
namespace OOP.View.Controls
{
    partial class AddressControl
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
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.postIndexLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postIndexTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryAddressLabel.Location = new System.Drawing.Point(12, 12);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(136, 17);
            this.deliveryAddressLabel.TabIndex = 0;
            this.deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // postIndexLabel
            // 
            this.postIndexLabel.AutoSize = true;
            this.postIndexLabel.Location = new System.Drawing.Point(12, 48);
            this.postIndexLabel.Name = "postIndexLabel";
            this.postIndexLabel.Size = new System.Drawing.Size(77, 17);
            this.postIndexLabel.TabIndex = 1;
            this.postIndexLabel.Text = "Post Index:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 83);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 17);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Country:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(12, 119);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(50, 17);
            this.streetLabel.TabIndex = 3;
            this.streetLabel.Text = "Street:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(12, 157);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(62, 17);
            this.buildingLabel.TabIndex = 4;
            this.buildingLabel.Text = "Building:";
            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(258, 157);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(77, 17);
            this.apartmentLabel.TabIndex = 5;
            this.apartmentLabel.Text = "Apartment:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(352, 83);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City:";
            // 
            // postIndexTextBox
            // 
            this.postIndexTextBox.Location = new System.Drawing.Point(104, 45);
            this.postIndexTextBox.Name = "postIndexTextBox";
            this.postIndexTextBox.Size = new System.Drawing.Size(148, 22);
            this.postIndexTextBox.TabIndex = 7;
            this.postIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(104, 80);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(242, 22);
            this.countryTextBox.TabIndex = 8;
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(104, 116);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(442, 22);
            this.streetTextBox.TabIndex = 9;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(393, 80);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(153, 22);
            this.cityTextBox.TabIndex = 10;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(104, 154);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(148, 22);
            this.buildingTextBox.TabIndex = 11;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(341, 154);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(205, 22);
            this.apartmentTextBox.TabIndex = 12;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.postIndexTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.apartmentLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.postIndexLabel);
            this.Controls.Add(this.deliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(570, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deliveryAddressLabel;
        private System.Windows.Forms.Label postIndexLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label apartmentLabel;
        private System.Windows.Forms.Label cityLabel;
        internal System.Windows.Forms.TextBox postIndexTextBox;
        internal System.Windows.Forms.TextBox countryTextBox;
        internal System.Windows.Forms.TextBox streetTextBox;
        internal System.Windows.Forms.TextBox cityTextBox;
        internal System.Windows.Forms.TextBox buildingTextBox;
        internal System.Windows.Forms.TextBox apartmentTextBox;
    }
}
