
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
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customerTab1 = new OOP.View.CustomerTab();
            this.customerTab2 = new OOP.View.CustomerTab();
            this.itemsTab1 = new OOP.View.Tabs.ItemsTab();
            this.itemsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.panel1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsTabPage.Size = new System.Drawing.Size(674, 454);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemsTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 450);
            this.panel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.itemsTabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(682, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customerTab2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(674, 454);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            this.customerTab1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTab1.Location = new System.Drawing.Point(3, 3);
            this.customerTab1.Margin = new System.Windows.Forms.Padding(2);
            this.customerTab1.Name = "customerTab1";
            this.customerTab1.Size = new System.Drawing.Size(866, 552);
            this.customerTab1.TabIndex = 0;
            // 
            // customerTab2
            // 
            this.customerTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTab2.Location = new System.Drawing.Point(2, 2);
            this.customerTab2.Margin = new System.Windows.Forms.Padding(2);
            this.customerTab2.Name = "customerTab2";
            this.customerTab2.Size = new System.Drawing.Size(670, 450);
            this.customerTab2.TabIndex = 0;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(670, 450);
            this.itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 480);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.itemsTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private View.CustomerTab customerTab1;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private View.Tabs.ItemsTab itemsTab1;
        private View.CustomerTab customerTab2;
    }
}

