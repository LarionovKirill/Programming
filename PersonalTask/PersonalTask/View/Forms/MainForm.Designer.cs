
namespace PersonalTask
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userInterface2 = new PersonalTask.View.UserInterface();
            this.userInterface1 = new PersonalTask.View.UserInterface();
            this.SuspendLayout();
            // 
            // userInterface2
            // 
            this.userInterface2.AutoSize = true;
            this.userInterface2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInterface2.Location = new System.Drawing.Point(0, 0);
            this.userInterface2.Name = "userInterface2";
            this.userInterface2.Size = new System.Drawing.Size(861, 528);
            this.userInterface2.TabIndex = 0;
            // 
            // userInterface1
            // 
            this.userInterface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInterface1.Location = new System.Drawing.Point(0, 0);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(861, 528);
            this.userInterface1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.Controls.Add(this.userInterface2);
            this.Name = "MainForm";
            this.Text = "Авиаперелеты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.UserInterface userInterface1;
        private View.UserInterface userInterface2;
    }
}

