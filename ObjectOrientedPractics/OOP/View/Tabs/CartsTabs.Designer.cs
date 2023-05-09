
namespace OOP.View.Tabs
{
    partial class CartsTabs
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
            this.itemsLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartTextBox = new System.Windows.Forms.TextBox();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(12, 10);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(37, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(323, 30);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(63, 13);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 468);
            this.listBox1.TabIndex = 2;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(15, 504);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(109, 36);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(410, 27);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(464, 24);
            this.customersComboBox.TabIndex = 4;
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(323, 88);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(35, 16);
            this.cartLabel.TabIndex = 5;
            this.cartLabel.Text = "Cart:";
            // 
            // cartTextBox
            // 
            this.cartTextBox.Location = new System.Drawing.Point(326, 120);
            this.cartTextBox.Multiline = true;
            this.cartTextBox.Name = "cartTextBox";
            this.cartTextBox.Size = new System.Drawing.Size(548, 178);
            this.cartTextBox.TabIndex = 6;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(326, 370);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(103, 42);
            this.createOrderButton.TabIndex = 7;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(771, 370);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(103, 42);
            this.clearCartButton.TabIndex = 8;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(653, 370);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(103, 42);
            this.removeItemButton.TabIndex = 9;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(804, 301);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(59, 15);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount:";
            // 
            // CartsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.cartTextBox);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemsLabel);
            this.Name = "CartsTabs";
            this.Size = new System.Drawing.Size(893, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.TextBox cartTextBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label amountLabel;
    }
}
