
namespace OOP.View.Tabs
{
    partial class CartsTab
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
			this.itemsListBox = new System.Windows.Forms.ListBox();
			this.itemLabel = new System.Windows.Forms.Label();
			this.addToCartButton = new System.Windows.Forms.Button();
			this.createOrderButton = new System.Windows.Forms.Button();
			this.clearCartButton = new System.Windows.Forms.Button();
			this.removeItemButton = new System.Windows.Forms.Button();
			this.customerLabel = new System.Windows.Forms.Label();
			this.customerComboBox = new System.Windows.Forms.ComboBox();
			this.cartLabel = new System.Windows.Forms.Label();
			this.amountLabel = new System.Windows.Forms.Label();
			this.amountPriceLabel = new System.Windows.Forms.Label();
			this.cartListBox = new System.Windows.Forms.ListBox();
			this.discountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.discountsLabel = new System.Windows.Forms.Label();
			this.discountAmountLabel = new System.Windows.Forms.Label();
			this.discountCostLabel = new System.Windows.Forms.Label();
			this.totalLabel = new System.Windows.Forms.Label();
			this.totalCostLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// itemsListBox
			// 
			this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.itemsListBox.FormattingEnabled = true;
			this.itemsListBox.Location = new System.Drawing.Point(10, 25);
			this.itemsListBox.Name = "itemsListBox";
			this.itemsListBox.Size = new System.Drawing.Size(270, 459);
			this.itemsListBox.TabIndex = 0;
			// 
			// itemLabel
			// 
			this.itemLabel.AutoSize = true;
			this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.itemLabel.Location = new System.Drawing.Point(7, 7);
			this.itemLabel.Name = "itemLabel";
			this.itemLabel.Size = new System.Drawing.Size(31, 13);
			this.itemLabel.TabIndex = 1;
			this.itemLabel.Text = "Item";
			// 
			// addToCartButton
			// 
			this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addToCartButton.Location = new System.Drawing.Point(10, 493);
			this.addToCartButton.Name = "addToCartButton";
			this.addToCartButton.Size = new System.Drawing.Size(110, 38);
			this.addToCartButton.TabIndex = 2;
			this.addToCartButton.Text = "Add To Cart";
			this.addToCartButton.UseVisualStyleBackColor = true;
			this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
			// 
			// createOrderButton
			// 
			this.createOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.createOrderButton.Location = new System.Drawing.Point(297, 265);
			this.createOrderButton.Name = "createOrderButton";
			this.createOrderButton.Size = new System.Drawing.Size(110, 38);
			this.createOrderButton.TabIndex = 3;
			this.createOrderButton.Text = "Create Order";
			this.createOrderButton.UseVisualStyleBackColor = true;
			this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
			// 
			// clearCartButton
			// 
			this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.clearCartButton.Location = new System.Drawing.Point(606, 265);
			this.clearCartButton.Name = "clearCartButton";
			this.clearCartButton.Size = new System.Drawing.Size(110, 38);
			this.clearCartButton.TabIndex = 4;
			this.clearCartButton.Text = "Clear Cart";
			this.clearCartButton.UseVisualStyleBackColor = true;
			this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
			// 
			// removeItemButton
			// 
			this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.removeItemButton.Location = new System.Drawing.Point(490, 265);
			this.removeItemButton.Name = "removeItemButton";
			this.removeItemButton.Size = new System.Drawing.Size(110, 38);
			this.removeItemButton.TabIndex = 5;
			this.removeItemButton.Text = "Remove Item";
			this.removeItemButton.UseVisualStyleBackColor = true;
			this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customerLabel.Location = new System.Drawing.Point(297, 24);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(63, 13);
			this.customerLabel.TabIndex = 6;
			this.customerLabel.Text = "Customer:";
			// 
			// customerComboBox
			// 
			this.customerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.customerComboBox.FormattingEnabled = true;
			this.customerComboBox.Location = new System.Drawing.Point(366, 21);
			this.customerComboBox.Name = "customerComboBox";
			this.customerComboBox.Size = new System.Drawing.Size(350, 21);
			this.customerComboBox.TabIndex = 7;
			this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
			// 
			// cartLabel
			// 
			this.cartLabel.AutoSize = true;
			this.cartLabel.Location = new System.Drawing.Point(297, 69);
			this.cartLabel.Name = "cartLabel";
			this.cartLabel.Size = new System.Drawing.Size(29, 13);
			this.cartLabel.TabIndex = 8;
			this.cartLabel.Text = "Cart:";
			// 
			// amountLabel
			// 
			this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.amountLabel.AutoSize = true;
			this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amountLabel.Location = new System.Drawing.Point(648, 221);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(63, 16);
			this.amountLabel.TabIndex = 10;
			this.amountLabel.Text = "Amount:";
			// 
			// amountPriceLabel
			// 
			this.amountPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.amountPriceLabel.AutoSize = true;
			this.amountPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amountPriceLabel.Location = new System.Drawing.Point(640, 237);
			this.amountPriceLabel.Name = "amountPriceLabel";
			this.amountPriceLabel.Size = new System.Drawing.Size(71, 25);
			this.amountPriceLabel.TabIndex = 11;
			this.amountPriceLabel.Text = "00,00";
			// 
			// cartListBox
			// 
			this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cartListBox.FormattingEnabled = true;
			this.cartListBox.Location = new System.Drawing.Point(297, 85);
			this.cartListBox.Name = "cartListBox";
			this.cartListBox.Size = new System.Drawing.Size(416, 121);
			this.cartListBox.TabIndex = 12;
			// 
			// discountsCheckedListBox
			// 
			this.discountsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.discountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.discountsCheckedListBox.FormattingEnabled = true;
			this.discountsCheckedListBox.Location = new System.Drawing.Point(297, 349);
			this.discountsCheckedListBox.Name = "discountsCheckedListBox";
			this.discountsCheckedListBox.Size = new System.Drawing.Size(216, 135);
			this.discountsCheckedListBox.TabIndex = 13;
			this.discountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsCheckedListBox_SelectedIndexChanged);
			// 
			// discountsLabel
			// 
			this.discountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.discountsLabel.AutoSize = true;
			this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.discountsLabel.Location = new System.Drawing.Point(297, 330);
			this.discountsLabel.Name = "discountsLabel";
			this.discountsLabel.Size = new System.Drawing.Size(67, 13);
			this.discountsLabel.TabIndex = 14;
			this.discountsLabel.Text = "Discounts:";
			// 
			// discountAmountLabel
			// 
			this.discountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.discountAmountLabel.AutoSize = true;
			this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.discountAmountLabel.Location = new System.Drawing.Point(609, 330);
			this.discountAmountLabel.Name = "discountAmountLabel";
			this.discountAmountLabel.Size = new System.Drawing.Size(107, 13);
			this.discountAmountLabel.TabIndex = 15;
			this.discountAmountLabel.Text = "Discount Amount:";
			// 
			// discountCostLabel
			// 
			this.discountCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.discountCostLabel.AutoSize = true;
			this.discountCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.discountCostLabel.Location = new System.Drawing.Point(640, 349);
			this.discountCostLabel.Name = "discountCostLabel";
			this.discountCostLabel.Size = new System.Drawing.Size(71, 25);
			this.discountCostLabel.TabIndex = 16;
			this.discountCostLabel.Text = "00,00";
			// 
			// totalLabel
			// 
			this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.totalLabel.AutoSize = true;
			this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.totalLabel.Location = new System.Drawing.Point(665, 488);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(51, 18);
			this.totalLabel.TabIndex = 17;
			this.totalLabel.Text = "Total:";
			// 
			// totalCostLabel
			// 
			this.totalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.totalCostLabel.AutoSize = true;
			this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.totalCostLabel.Location = new System.Drawing.Point(645, 506);
			this.totalCostLabel.Name = "totalCostLabel";
			this.totalCostLabel.Size = new System.Drawing.Size(71, 25);
			this.totalCostLabel.TabIndex = 18;
			this.totalCostLabel.Text = "00,00";
			// 
			// CartsTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.totalCostLabel);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.discountCostLabel);
			this.Controls.Add(this.discountAmountLabel);
			this.Controls.Add(this.discountsLabel);
			this.Controls.Add(this.discountsCheckedListBox);
			this.Controls.Add(this.cartListBox);
			this.Controls.Add(this.amountPriceLabel);
			this.Controls.Add(this.amountLabel);
			this.Controls.Add(this.cartLabel);
			this.Controls.Add(this.customerComboBox);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.removeItemButton);
			this.Controls.Add(this.clearCartButton);
			this.Controls.Add(this.createOrderButton);
			this.Controls.Add(this.addToCartButton);
			this.Controls.Add(this.itemLabel);
			this.Controls.Add(this.itemsListBox);
			this.Name = "CartsTab";
			this.Size = new System.Drawing.Size(735, 543);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountPriceLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.CheckedListBox discountsCheckedListBox;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label discountCostLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}
