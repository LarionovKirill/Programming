﻿
namespace OOP
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
            this.customerTab1 = new OOP.View.CustomerTab();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new OOP.View.Tabs.ItemsTab();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customerTab2 = new OOP.View.CustomerTab();
            this.itemsTabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTab1
            // 
            this.customerTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTab1.Location = new System.Drawing.Point(3, 3);
            this.customerTab1.Name = "customerTab1";
            this.customerTab1.Size = new System.Drawing.Size(866, 552);
            this.customerTab1.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(872, 558);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(866, 552);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.itemsTabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(880, 587);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customerTab2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 558);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerTab2
            // 
            this.customerTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTab2.Location = new System.Drawing.Point(3, 3);
            this.customerTab2.Name = "customerTab2";
            this.customerTab2.Size = new System.Drawing.Size(866, 552);
            this.customerTab2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 587);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.itemsTabPage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private View.CustomerTab customerTab1;
        private System.Windows.Forms.TabPage itemsTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private View.CustomerTab customerTab2;
    }
}

