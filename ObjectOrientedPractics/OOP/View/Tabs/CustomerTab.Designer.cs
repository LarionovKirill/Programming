
namespace OOP.View
{
    partial class CustomerTab
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
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idCustomerTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.isPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.addressControl = new OOP.View.AddressControl();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountListBox = new System.Windows.Forms.ListBox();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(284, 8);
            this.selectedCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(117, 13);
            this.selectedCustomerLabel.TabIndex = 36;
            this.selectedCustomerLabel.Text = "Selected Customer:";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(8, 8);
            this.customersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(69, 13);
            this.customersLabel.TabIndex = 35;
            this.customersLabel.Text = "Customers:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(284, 66);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(38, 13);
            this.fullNameLabel.TabIndex = 33;
            this.fullNameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(284, 37);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 32;
            this.idLabel.Text = "ID:";
            // 
            // idCustomerTextBox
            // 
            this.idCustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idCustomerTextBox.Location = new System.Drawing.Point(325, 35);
            this.idCustomerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCustomerTextBox.Name = "idCustomerTextBox";
            this.idCustomerTextBox.ReadOnly = true;
            this.idCustomerTextBox.Size = new System.Drawing.Size(186, 20);
            this.idCustomerTextBox.TabIndex = 31;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(325, 63);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.fullNameTextBox.TabIndex = 30;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCustomerButton.Location = new System.Drawing.Point(188, 498);
            this.removeCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(76, 44);
            this.removeCustomerButton.TabIndex = 28;
            this.removeCustomerButton.Text = "Remove";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            this.removeCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCustomerButton.Location = new System.Drawing.Point(10, 498);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(76, 44);
            this.addCustomerButton.TabIndex = 27;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(10, 24);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(255, 459);
            this.customerListBox.TabIndex = 26;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerListBox_SelectedIndexChanged);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeButton.Location = new System.Drawing.Point(100, 498);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 44);
            this.changeButton.TabIndex = 38;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(287, 498);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 44);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(692, 498);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 44);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // isPriorityCheckBox
            // 
            this.isPriorityCheckBox.AutoSize = true;
            this.isPriorityCheckBox.Location = new System.Drawing.Point(286, 98);
            this.isPriorityCheckBox.Name = "isPriorityCheckBox";
            this.isPriorityCheckBox.Size = new System.Drawing.Size(65, 17);
            this.isPriorityCheckBox.TabIndex = 39;
            this.isPriorityCheckBox.Text = "IsPriority";
            this.isPriorityCheckBox.UseVisualStyleBackColor = true;
            this.isPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // addressControl
            // 
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Location = new System.Drawing.Point(269, 120);
            this.addressControl.Margin = new System.Windows.Forms.Padding(2);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(512, 165);
            this.addressControl.TabIndex = 41;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.Location = new System.Drawing.Point(283, 287);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(67, 13);
            this.discountLabel.TabIndex = 42;
            this.discountLabel.Text = "Discounts:";
            // 
            // discountListBox
            // 
            this.discountListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountListBox.FormattingEnabled = true;
            this.discountListBox.Location = new System.Drawing.Point(286, 303);
            this.discountListBox.Name = "discountListBox";
            this.discountListBox.Size = new System.Drawing.Size(259, 95);
            this.discountListBox.TabIndex = 43;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addDiscountButton.Location = new System.Drawing.Point(561, 303);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(85, 36);
            this.addDiscountButton.TabIndex = 44;
            this.addDiscountButton.Text = "Add";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeDiscountButton.Location = new System.Drawing.Point(561, 362);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(85, 36);
            this.removeDiscountButton.TabIndex = 45;
            this.removeDiscountButton.Text = "Remove";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            //
            // CustomerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeDiscountButton);
            this.Controls.Add(this.addDiscountButton);
            this.Controls.Add(this.discountListBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.addressControl);
            this.Controls.Add(this.isPriorityCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.selectedCustomerLabel);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idCustomerTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerTab";
            this.Size = new System.Drawing.Size(792, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idCustomerTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.CheckBox isPriorityCheckBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private AddressControl addressControl;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.ListBox discountListBox;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button removeDiscountButton;
    }
}
