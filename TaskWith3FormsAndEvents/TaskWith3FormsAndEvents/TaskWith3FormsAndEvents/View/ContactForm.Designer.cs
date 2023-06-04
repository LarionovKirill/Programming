
namespace TaskWith3FormsAndEvents
{
	partial class ContactForm
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
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 44);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "Full Name:";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(12, 244);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(45, 13);
			this.addressLabel.TabIndex = 1;
			this.addressLabel.Text = "Address";
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(12, 144);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
			this.phoneNumberLabel.TabIndex = 2;
			this.phoneNumberLabel.Text = "Phone Number:";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Location = new System.Drawing.Point(12, 60);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(353, 20);
			this.fullNameTextBox.TabIndex = 3;
			this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(12, 160);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(353, 20);
			this.phoneTextBox.TabIndex = 4;
			this.phoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(12, 260);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(353, 20);
			this.addressTextBox.TabIndex = 5;
			this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(290, 353);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 6;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 388);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.phoneNumberLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.fullNameLabel);
			this.Name = "ContactForm";
			this.Text = "ContactForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.Label phoneNumberLabel;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Button closeButton;
	}
}