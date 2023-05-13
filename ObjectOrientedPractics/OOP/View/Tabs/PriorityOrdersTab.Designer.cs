
namespace OOP.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.addressControl1 = new OOP.View.AddressControl();
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.priorityOptionsLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ordersItemLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearOrderIutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressControl1
            // 
            this.addressControl1.Address = null;
            this.addressControl1.Location = new System.Drawing.Point(0, 131);
            this.addressControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(697, 187);
            this.addressControl1.TabIndex = 0;
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedOrderLabel.Location = new System.Drawing.Point(3, 12);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(117, 16);
            this.selectedOrderLabel.TabIndex = 1;
            this.selectedOrderLabel.Text = "Selected Order:";
            // 
            // priorityOptionsLabel
            // 
            this.priorityOptionsLabel.AutoSize = true;
            this.priorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityOptionsLabel.Location = new System.Drawing.Point(319, 12);
            this.priorityOptionsLabel.Name = "priorityOptionsLabel";
            this.priorityOptionsLabel.Size = new System.Drawing.Size(118, 16);
            this.priorityOptionsLabel.TabIndex = 2;
            this.priorityOptionsLabel.Text = "Priority Options:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(3, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 16);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(3, 72);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(59, 16);
            this.createdLabel.TabIndex = 4;
            this.createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 105);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 16);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(67, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(138, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // createdTextBox
            // 
            this.createdTextBox.Location = new System.Drawing.Point(67, 69);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(138, 22);
            this.createdTextBox.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(67, 102);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(138, 24);
            this.statusComboBox.TabIndex = 8;
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(319, 43);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(95, 16);
            this.deliveryTimeLabel.TabIndex = 9;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(420, 40);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(152, 24);
            this.deliveryTimeComboBox.TabIndex = 10;
            // 
            // ordersItemLabel
            // 
            this.ordersItemLabel.AutoSize = true;
            this.ordersItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersItemLabel.Location = new System.Drawing.Point(3, 334);
            this.ordersItemLabel.Name = "ordersItemLabel";
            this.ordersItemLabel.Size = new System.Drawing.Size(92, 16);
            this.ordersItemLabel.TabIndex = 11;
            this.ordersItemLabel.Text = "Order Items:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(3, 353);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(694, 164);
            this.itemsListBox.TabIndex = 12;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(634, 520);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(63, 16);
            this.amountLabel.TabIndex = 13;
            this.amountLabel.Text = "Amount:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(626, 536);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(71, 25);
            this.costLabel.TabIndex = 14;
            this.costLabel.Text = "00,00";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 567);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(120, 41);
            this.addItemButton.TabIndex = 15;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(132, 567);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(120, 41);
            this.removeItemButton.TabIndex = 16;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // clearOrderIutton
            // 
            this.clearOrderIutton.Location = new System.Drawing.Point(577, 567);
            this.clearOrderIutton.Name = "clearOrderIutton";
            this.clearOrderIutton.Size = new System.Drawing.Size(120, 41);
            this.clearOrderIutton.TabIndex = 17;
            this.clearOrderIutton.Text = "Clear Order";
            this.clearOrderIutton.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearOrderIutton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.ordersItemLabel);
            this.Controls.Add(this.deliveryTimeComboBox);
            this.Controls.Add(this.deliveryTimeLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.priorityOptionsLabel);
            this.Controls.Add(this.selectedOrderLabel);
            this.Controls.Add(this.addressControl1);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(700, 634);
            this.Load += new System.EventHandler(this.PriorityOrdersTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AddressControl addressControl1;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label ordersItemLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearOrderIutton;
    }
}
