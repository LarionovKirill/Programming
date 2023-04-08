
namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            this.enumerationsBox = new System.Windows.Forms.GroupBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.chooseValue = new System.Windows.Forms.Label();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.enumaration = new System.Windows.Forms.Label();
            this.intValue = new System.Windows.Forms.Label();
            this.intValues = new System.Windows.Forms.TextBox();
            this.enumerationsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enumerationsBox
            // 
            this.enumerationsBox.Controls.Add(this.valuesListBox);
            this.enumerationsBox.Controls.Add(this.chooseValue);
            this.enumerationsBox.Controls.Add(this.enumsListBox);
            this.enumerationsBox.Controls.Add(this.enumaration);
            this.enumerationsBox.Controls.Add(this.intValue);
            this.enumerationsBox.Controls.Add(this.intValues);
            this.enumerationsBox.Location = new System.Drawing.Point(0, 0);
            this.enumerationsBox.Name = "enumerationsBox";
            this.enumerationsBox.Size = new System.Drawing.Size(886, 326);
            this.enumerationsBox.TabIndex = 0;
            this.enumerationsBox.TabStop = false;
            this.enumerationsBox.Text = "Enumerations";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 16;
            this.valuesListBox.Location = new System.Drawing.Point(254, 48);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(175, 212);
            this.valuesListBox.TabIndex = 7;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // chooseValue
            // 
            this.chooseValue.AutoSize = true;
            this.chooseValue.Location = new System.Drawing.Point(251, 28);
            this.chooseValue.Name = "chooseValue";
            this.chooseValue.Size = new System.Drawing.Size(100, 17);
            this.chooseValue.TabIndex = 10;
            this.chooseValue.Text = "Choose Value:";
            // 
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.ItemHeight = 16;
            this.enumsListBox.Location = new System.Drawing.Point(30, 48);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(175, 212);
            this.enumsListBox.TabIndex = 6;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // enumaration
            // 
            this.enumaration.AutoSize = true;
            this.enumaration.Location = new System.Drawing.Point(27, 28);
            this.enumaration.Name = "enumaration";
            this.enumaration.Size = new System.Drawing.Size(143, 17);
            this.enumaration.TabIndex = 11;
            this.enumaration.Text = "Choose enumaration:";
            // 
            // intValue
            // 
            this.intValue.AutoSize = true;
            this.intValue.Location = new System.Drawing.Point(537, 28);
            this.intValue.Name = "intValue";
            this.intValue.Size = new System.Drawing.Size(67, 17);
            this.intValue.TabIndex = 9;
            this.intValue.Text = "Int Value:";
            // 
            // intValues
            // 
            this.intValues.Location = new System.Drawing.Point(540, 48);
            this.intValues.Multiline = true;
            this.intValues.Name = "intValues";
            this.intValues.Size = new System.Drawing.Size(148, 28);
            this.intValues.TabIndex = 8;
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enumerationsBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(886, 326);
            this.enumerationsBox.ResumeLayout(false);
            this.enumerationsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enumerationsBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label chooseValue;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.Label enumaration;
        private System.Windows.Forms.Label intValue;
        private System.Windows.Forms.TextBox intValues;
    }
}
