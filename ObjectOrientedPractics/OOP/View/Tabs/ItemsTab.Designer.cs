
namespace OOP.View.Tabs
{
    partial class ItemsTab
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
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.descriptionItemTextBox = new System.Windows.Forms.TextBox();
            this.nameItemTextBox = new System.Windows.Forms.TextBox();
            this.costItemTextBox = new System.Windows.Forms.TextBox();
            this.idItemTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(9, 24);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(272, 368);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addItemButton.Location = new System.Drawing.Point(10, 396);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(86, 44);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // descriptionItemTextBox
            // 
            this.descriptionItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionItemTextBox.Location = new System.Drawing.Point(296, 274);
            this.descriptionItemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionItemTextBox.Multiline = true;
            this.descriptionItemTextBox.Name = "descriptionItemTextBox";
            this.descriptionItemTextBox.Size = new System.Drawing.Size(357, 118);
            this.descriptionItemTextBox.TabIndex = 3;
            this.descriptionItemTextBox.TextChanged += new System.EventHandler(this.DescriptionItemTextBox_TextChanged);
            // 
            // nameItemTextBox
            // 
            this.nameItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameItemTextBox.Location = new System.Drawing.Point(297, 156);
            this.nameItemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameItemTextBox.Multiline = true;
            this.nameItemTextBox.Name = "nameItemTextBox";
            this.nameItemTextBox.Size = new System.Drawing.Size(357, 91);
            this.nameItemTextBox.TabIndex = 4;
            this.nameItemTextBox.TextChanged += new System.EventHandler(this.NameItemTextBox_TextChanged);
            // 
            // costItemTextBox
            // 
            this.costItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costItemTextBox.Location = new System.Drawing.Point(349, 68);
            this.costItemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costItemTextBox.Name = "costItemTextBox";
            this.costItemTextBox.Size = new System.Drawing.Size(113, 20);
            this.costItemTextBox.TabIndex = 5;
            this.costItemTextBox.TextChanged += new System.EventHandler(this.СostItemTextBox_TextChanged);
            // 
            // idItemTextBox
            // 
            this.idItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idItemTextBox.Location = new System.Drawing.Point(349, 37);
            this.idItemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idItemTextBox.Name = "idItemTextBox";
            this.idItemTextBox.ReadOnly = true;
            this.idItemTextBox.Size = new System.Drawing.Size(113, 20);
            this.idItemTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(295, 40);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(294, 71);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(295, 140);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(294, 258);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description:";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(7, 7);
            this.itemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(41, 13);
            this.itemsLabel.TabIndex = 11;
            this.itemsLabel.Text = "Items:";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(299, 9);
            this.selectedItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(89, 13);
            this.selectedItemLabel.TabIndex = 12;
            this.selectedItemLabel.Text = "Selected Item:";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeItemButton.Location = new System.Drawing.Point(195, 396);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(86, 44);
            this.removeItemButton.TabIndex = 2;
            this.removeItemButton.Text = "Remove";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(293, 98);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "ItemCategory:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(349, 95);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(113, 21);
            this.categoryComboBox.TabIndex = 14;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.СategoryComboBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.selectedItemLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idItemTextBox);
            this.Controls.Add(this.costItemTextBox);
            this.Controls.Add(this.nameItemTextBox);
            this.Controls.Add(this.descriptionItemTextBox);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(670, 450);
            this.Load += new System.EventHandler(this.ItemsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox descriptionItemTextBox;
        private System.Windows.Forms.TextBox nameItemTextBox;
        private System.Windows.Forms.TextBox costItemTextBox;
        private System.Windows.Forms.TextBox idItemTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}
