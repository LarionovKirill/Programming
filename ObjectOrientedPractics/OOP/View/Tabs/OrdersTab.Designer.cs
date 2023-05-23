
namespace OOP.View.Tabs
{
    partial class ordersTab
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
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.creationTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.ordersItemsLabel = new System.Windows.Forms.Label();
            this.ordersItemsListBox = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.informationTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.priorityPanel = new System.Windows.Forms.Panel();
            this.addressControl = new OOP.View.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.informationTable)).BeginInit();
            this.priorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedOrderLabel.Location = new System.Drawing.Point(443, 9);
            this.selectedOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(113, 16);
            this.selectedOrderLabel.TabIndex = 1;
            this.selectedOrderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(443, 29);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(443, 53);
            this.createdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 3;
            this.createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(443, 77);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(500, 27);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(195, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // creationTextBox
            // 
            this.creationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creationTextBox.Location = new System.Drawing.Point(500, 50);
            this.creationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.creationTextBox.Name = "creationTextBox";
            this.creationTextBox.ReadOnly = true;
            this.creationTextBox.Size = new System.Drawing.Size(195, 20);
            this.creationTextBox.TabIndex = 6;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(500, 75);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(195, 21);
            this.statusComboBox.TabIndex = 7;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersLabel.Location = new System.Drawing.Point(9, 9);
            this.ordersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(55, 16);
            this.ordersLabel.TabIndex = 8;
            this.ordersLabel.Text = "Orders";
            // 
            // ordersItemsLabel
            // 
            this.ordersItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersItemsLabel.AutoSize = true;
            this.ordersItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersItemsLabel.Location = new System.Drawing.Point(443, 272);
            this.ordersItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordersItemsLabel.Name = "ordersItemsLabel";
            this.ordersItemsLabel.Size = new System.Drawing.Size(96, 16);
            this.ordersItemsLabel.TabIndex = 9;
            this.ordersItemsLabel.Text = "Orders Items";
            // 
            // ordersItemsListBox
            // 
            this.ordersItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersItemsListBox.FormattingEnabled = true;
            this.ordersItemsListBox.Location = new System.Drawing.Point(446, 290);
            this.ordersItemsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ordersItemsListBox.Name = "ordersItemsListBox";
            this.ordersItemsListBox.Size = new System.Drawing.Size(439, 173);
            this.ordersItemsListBox.TabIndex = 10;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(813, 473);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(63, 16);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount:";
            // 
            // costLabel
            // 
            this.costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(816, 493);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(60, 24);
            this.costLabel.TabIndex = 12;
            this.costLabel.Text = "00,00";
            // 
            // informationTable
            // 
            this.informationTable.AllowUserToAddRows = false;
            this.informationTable.AllowUserToResizeRows = false;
            this.informationTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.informationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.FullName,
            this.Address,
            this.Cost,
            this.Status});
            this.informationTable.Location = new System.Drawing.Point(11, 24);
            this.informationTable.Margin = new System.Windows.Forms.Padding(2);
            this.informationTable.MultiSelect = false;
            this.informationTable.Name = "informationTable";
            this.informationTable.RowHeadersWidth = 51;
            this.informationTable.RowTemplate.Height = 24;
            this.informationTable.Size = new System.Drawing.Size(428, 537);
            this.informationTable.TabIndex = 13;
            this.informationTable.SelectionChanged += new System.EventHandler(this.InformationTable_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Creating Date";
            this.Date.Name = "Date";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Priority Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(91, 22);
            this.deliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(86, 21);
            this.deliveryTimeComboBox.TabIndex = 17;
            this.deliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // priorityPanel
            // 
            this.priorityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityPanel.Controls.Add(this.label1);
            this.priorityPanel.Controls.Add(this.deliveryTimeComboBox);
            this.priorityPanel.Controls.Add(this.label2);
            this.priorityPanel.Location = new System.Drawing.Point(699, 5);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(185, 96);
            this.priorityPanel.TabIndex = 18;
            // 
            // addressControl
            // 
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Location = new System.Drawing.Point(446, 106);
            this.addressControl.Margin = new System.Windows.Forms.Padding(2);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(438, 165);
            this.addressControl.TabIndex = 19;
            // 
            // ordersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressControl);
            this.Controls.Add(this.priorityPanel);
            this.Controls.Add(this.informationTable);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.ordersItemsListBox);
            this.Controls.Add(this.ordersItemsLabel);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.creationTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.selectedOrderLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ordersTab";
            this.Size = new System.Drawing.Size(896, 575);
            this.Load += new System.EventHandler(this.OrdersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationTable)).EndInit();
            this.priorityPanel.ResumeLayout(false);
            this.priorityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox creationTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label ordersItemsLabel;
        private System.Windows.Forms.ListBox ordersItemsListBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.DataGridView informationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Panel priorityPanel;
        private AddressControl addressControl;
    }
}
