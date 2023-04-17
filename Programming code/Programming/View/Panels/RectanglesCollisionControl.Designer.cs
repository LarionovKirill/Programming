
namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.buttonRemoveRectangle = new System.Windows.Forms.Button();
            this.buttonAddRectangle = new System.Windows.Forms.Button();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.lengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.widthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rectanglesLabel = new System.Windows.Forms.Label();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.panelForRectangles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonRemoveRectangle
            // 
            this.buttonRemoveRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveRectangle.Location = new System.Drawing.Point(267, 250);
            this.buttonRemoveRectangle.Name = "buttonRemoveRectangle";
            this.buttonRemoveRectangle.Size = new System.Drawing.Size(83, 36);
            this.buttonRemoveRectangle.TabIndex = 31;
            this.buttonRemoveRectangle.Text = "Remove";
            this.buttonRemoveRectangle.UseVisualStyleBackColor = true;
            this.buttonRemoveRectangle.Click += new System.EventHandler(this.buttonRemoveRectangle_Click);
            // 
            // buttonAddRectangle
            // 
            this.buttonAddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRectangle.Location = new System.Drawing.Point(76, 250);
            this.buttonAddRectangle.Name = "buttonAddRectangle";
            this.buttonAddRectangle.Size = new System.Drawing.Size(75, 36);
            this.buttonAddRectangle.TabIndex = 30;
            this.buttonAddRectangle.Text = "Add";
            this.buttonAddRectangle.UseVisualStyleBackColor = true;
            this.buttonAddRectangle.Click += new System.EventHandler(this.buttonAddRectangle_Click);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(14, 490);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(56, 17);
            this.labelLength.TabIndex = 29;
            this.labelLength.Text = "Length:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(22, 450);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(48, 17);
            this.labelWidth.TabIndex = 28;
            this.labelWidth.Text = "Width:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(43, 414);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 17);
            this.labelY.TabIndex = 27;
            this.labelY.Text = "Y:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(43, 374);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 17);
            this.labelX.TabIndex = 26;
            this.labelX.Text = "X:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(43, 336);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 25;
            this.idLabel.Text = "ID:";
            // 
            // lengthRectangleTextBox
            // 
            this.lengthRectangleTextBox.Location = new System.Drawing.Point(76, 487);
            this.lengthRectangleTextBox.Name = "lengthRectangleTextBox";
            this.lengthRectangleTextBox.Size = new System.Drawing.Size(100, 22);
            this.lengthRectangleTextBox.TabIndex = 24;
            this.lengthRectangleTextBox.TextChanged += new System.EventHandler(this.lengthRectangleTextBox_TextChanged);
            // 
            // widthRectangleTextBox
            // 
            this.widthRectangleTextBox.Location = new System.Drawing.Point(76, 450);
            this.widthRectangleTextBox.Name = "widthRectangleTextBox";
            this.widthRectangleTextBox.Size = new System.Drawing.Size(100, 22);
            this.widthRectangleTextBox.TabIndex = 23;
            this.widthRectangleTextBox.TextChanged += new System.EventHandler(this.widthRectangleTextBox_TextChanged);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(76, 412);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 22;
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(76, 374);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 21;
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(76, 336);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selected Rectangle:";
            // 
            // rectanglesLabel
            // 
            this.rectanglesLabel.AutoSize = true;
            this.rectanglesLabel.Location = new System.Drawing.Point(8, 12);
            this.rectanglesLabel.Name = "rectanglesLabel";
            this.rectanglesLabel.Size = new System.Drawing.Size(83, 17);
            this.rectanglesLabel.TabIndex = 18;
            this.rectanglesLabel.Text = "Rectangles:";
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.ItemHeight = 16;
            this.rectanglesListBox.Location = new System.Drawing.Point(8, 32);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(428, 212);
            this.rectanglesListBox.TabIndex = 17;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.rectanglesListBox_SelectedIndexChanged);
            // 
            // panelForRectangles
            // 
            this.panelForRectangles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForRectangles.Location = new System.Drawing.Point(453, 12);
            this.panelForRectangles.Name = "panelForRectangles";
            this.panelForRectangles.Size = new System.Drawing.Size(480, 510);
            this.panelForRectangles.TabIndex = 32;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForRectangles);
            this.Controls.Add(this.buttonRemoveRectangle);
            this.Controls.Add(this.buttonAddRectangle);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lengthRectangleTextBox);
            this.Controls.Add(this.widthRectangleTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rectanglesLabel);
            this.Controls.Add(this.rectanglesListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(948, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveRectangle;
        private System.Windows.Forms.Button buttonAddRectangle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox lengthRectangleTextBox;
        private System.Windows.Forms.TextBox widthRectangleTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rectanglesLabel;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Panel panelForRectangles;
    }
}
