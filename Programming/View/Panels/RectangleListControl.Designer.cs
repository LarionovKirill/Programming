
namespace Programming.View.Panels
{
    partial class RectangleListControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idRectangleLabel = new System.Windows.Forms.Label();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.yRectangleLabel = new System.Windows.Forms.Label();
            this.yRectangleTextBox = new System.Windows.Forms.TextBox();
            this.xRectangleLabel = new System.Windows.Forms.Label();
            this.xRectangleTextBox = new System.Windows.Forms.TextBox();
            this.findRectanglesButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.rectangleListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idRectangleLabel);
            this.groupBox1.Controls.Add(this.IdRectangleTextBox);
            this.groupBox1.Controls.Add(this.yRectangleLabel);
            this.groupBox1.Controls.Add(this.yRectangleTextBox);
            this.groupBox1.Controls.Add(this.xRectangleLabel);
            this.groupBox1.Controls.Add(this.xRectangleTextBox);
            this.groupBox1.Controls.Add(this.findRectanglesButton);
            this.groupBox1.Controls.Add(this.colorLabel);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.colorTextBox);
            this.groupBox1.Controls.Add(this.widthTextBox);
            this.groupBox1.Controls.Add(this.lengthTextBox);
            this.groupBox1.Controls.Add(this.rectangleListBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // idRectangleLabel
            // 
            this.idRectangleLabel.AutoSize = true;
            this.idRectangleLabel.Location = new System.Drawing.Point(242, 17);
            this.idRectangleLabel.Name = "idRectangleLabel";
            this.idRectangleLabel.Size = new System.Drawing.Size(23, 17);
            this.idRectangleLabel.TabIndex = 27;
            this.idRectangleLabel.Text = "Id:";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(243, 37);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(112, 22);
            this.IdRectangleTextBox.TabIndex = 26;
            // 
            // yRectangleLabel
            // 
            this.yRectangleLabel.AutoSize = true;
            this.yRectangleLabel.Location = new System.Drawing.Point(242, 357);
            this.yRectangleLabel.Name = "yRectangleLabel";
            this.yRectangleLabel.Size = new System.Drawing.Size(21, 17);
            this.yRectangleLabel.TabIndex = 25;
            this.yRectangleLabel.Text = "Y:";
            // 
            // yRectangleTextBox
            // 
            this.yRectangleTextBox.Location = new System.Drawing.Point(243, 377);
            this.yRectangleTextBox.Name = "yRectangleTextBox";
            this.yRectangleTextBox.ReadOnly = true;
            this.yRectangleTextBox.Size = new System.Drawing.Size(112, 22);
            this.yRectangleTextBox.TabIndex = 24;
            // 
            // xRectangleLabel
            // 
            this.xRectangleLabel.AutoSize = true;
            this.xRectangleLabel.Location = new System.Drawing.Point(242, 283);
            this.xRectangleLabel.Name = "xRectangleLabel";
            this.xRectangleLabel.Size = new System.Drawing.Size(21, 17);
            this.xRectangleLabel.TabIndex = 23;
            this.xRectangleLabel.Text = "X:";
            // 
            // xRectangleTextBox
            // 
            this.xRectangleTextBox.Location = new System.Drawing.Point(243, 303);
            this.xRectangleTextBox.Name = "xRectangleTextBox";
            this.xRectangleTextBox.ReadOnly = true;
            this.xRectangleTextBox.Size = new System.Drawing.Size(112, 22);
            this.xRectangleTextBox.TabIndex = 22;
            // 
            // findRectanglesButton
            // 
            this.findRectanglesButton.Location = new System.Drawing.Point(243, 429);
            this.findRectanglesButton.Name = "findRectanglesButton";
            this.findRectanglesButton.Size = new System.Drawing.Size(112, 26);
            this.findRectanglesButton.TabIndex = 21;
            this.findRectanglesButton.Text = "Find";
            this.findRectanglesButton.UseVisualStyleBackColor = true;
            this.findRectanglesButton.TextChanged += new System.EventHandler(this.FindRectangleWithMaxWidth);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(242, 213);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 17);
            this.colorLabel.TabIndex = 20;
            this.colorLabel.Text = "Color:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(240, 141);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 19;
            this.widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(240, 76);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 18;
            this.lengthLabel.Text = "Length:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(243, 233);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(112, 22);
            this.colorTextBox.TabIndex = 17;
            this.colorTextBox.TextChanged += new System.EventHandler(this.ColorTextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(243, 161);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(112, 22);
            this.widthTextBox.TabIndex = 16;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextChanged);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(243, 96);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(112, 22);
            this.lengthTextBox.TabIndex = 15;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.LengthTextChanged);
            // 
            // rectangleListBox
            // 
            this.rectangleListBox.FormattingEnabled = true;
            this.rectangleListBox.ItemHeight = 16;
            this.rectangleListBox.Location = new System.Drawing.Point(17, 21);
            this.rectangleListBox.Name = "rectangleListBox";
            this.rectangleListBox.Size = new System.Drawing.Size(190, 436);
            this.rectangleListBox.TabIndex = 14;
            this.rectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectangleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RectangleListControl";
            this.Size = new System.Drawing.Size(411, 484);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idRectangleLabel;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label yRectangleLabel;
        private System.Windows.Forms.TextBox yRectangleTextBox;
        private System.Windows.Forms.Label xRectangleLabel;
        private System.Windows.Forms.TextBox xRectangleTextBox;
        private System.Windows.Forms.Button findRectanglesButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.ListBox rectangleListBox;
    }
}
