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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.orderPanel = new System.Windows.Forms.Panel();
			this.ordersTab1 = new OOP.View.Tabs.ordersTab();
			this.cartsTabPage = new System.Windows.Forms.TabPage();
			this.cartsTab = new OOP.View.Tabs.CartsTab();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.customerTab2 = new OOP.View.CustomerTab();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.itemsTabPage = new System.Windows.Forms.TabPage();
			this.itemsTab1 = new OOP.View.Tabs.ItemsTab();
			this.customerTab1 = new OOP.View.CustomerTab();
			this.itemsTab = new OOP.View.Tabs.ItemsTab();
			this.tabPage2.SuspendLayout();
			this.orderPanel.SuspendLayout();
			this.cartsTabPage.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.itemsTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.orderPanel);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(1182, 674);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "Orders";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// orderPanel
			// 
			this.orderPanel.Controls.Add(this.ordersTab1);
			this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderPanel.Location = new System.Drawing.Point(2, 2);
			this.orderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.orderPanel.Name = "orderPanel";
			this.orderPanel.Size = new System.Drawing.Size(1178, 670);
			this.orderPanel.TabIndex = 0;
			// 
			// ordersTab1
			// 
			this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ordersTab1.Location = new System.Drawing.Point(0, 0);
			this.ordersTab1.Margin = new System.Windows.Forms.Padding(2);
			this.ordersTab1.Name = "ordersTab1";
			this.ordersTab1.Size = new System.Drawing.Size(1178, 670);
			this.ordersTab1.TabIndex = 0;
			// 
			// cartsTabPage
			// 
			this.cartsTabPage.Controls.Add(this.cartsTab);
			this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
			this.cartsTabPage.Margin = new System.Windows.Forms.Padding(2);
			this.cartsTabPage.Name = "cartsTabPage";
			this.cartsTabPage.Padding = new System.Windows.Forms.Padding(2);
			this.cartsTabPage.Size = new System.Drawing.Size(1182, 674);
			this.cartsTabPage.TabIndex = 2;
			this.cartsTabPage.Text = "Carts";
			this.cartsTabPage.UseVisualStyleBackColor = true;
			// 
			// cartsTab
			// 
			this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartsTab.Location = new System.Drawing.Point(2, 2);
			this.cartsTab.Name = "cartsTab";
			this.cartsTab.Size = new System.Drawing.Size(1178, 670);
			this.cartsTab.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.customerTab2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(1182, 674);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "Customer";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// customerTab2
			// 
			this.customerTab2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerTab2.Location = new System.Drawing.Point(2, 2);
			this.customerTab2.Margin = new System.Windows.Forms.Padding(2);
			this.customerTab2.Name = "customerTab2";
			this.customerTab2.Size = new System.Drawing.Size(1178, 670);
			this.customerTab2.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.itemsTabPage);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.cartsTabPage);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1190, 700);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// itemsTabPage
			// 
			this.itemsTabPage.Controls.Add(this.itemsTab1);
			this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
			this.itemsTabPage.Name = "itemsTabPage";
			this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.itemsTabPage.Size = new System.Drawing.Size(1182, 674);
			this.itemsTabPage.TabIndex = 4;
			this.itemsTabPage.Text = "Items";
			this.itemsTabPage.UseVisualStyleBackColor = true;
			// 
			// itemsTab1
			// 
			this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsTab1.Location = new System.Drawing.Point(3, 3);
			this.itemsTab1.Margin = new System.Windows.Forms.Padding(2);
			this.itemsTab1.Name = "itemsTab1";
			this.itemsTab1.Size = new System.Drawing.Size(1176, 668);
			this.itemsTab1.TabIndex = 0;
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
			// itemsTab
			// 
			this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsTab.Location = new System.Drawing.Point(0, 0);
			this.itemsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.itemsTab.Name = "itemsTab";
			this.itemsTab.Size = new System.Drawing.Size(1083, 635);
			this.itemsTab.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1190, 700);
			this.Controls.Add(this.tabControl);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Object Oriented Practics";
			this.tabPage2.ResumeLayout(false);
			this.orderPanel.ResumeLayout(false);
			this.cartsTabPage.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.itemsTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private View.CustomerTab customerTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage cartsTabPage;
        private View.Tabs.ItemsTab itemsTab;
        private View.Tabs.ordersTab ordersTab1;
        private View.Tabs.CartsTab cartsTab;
        private View.CustomerTab customerTab2;
		private System.Windows.Forms.TabPage itemsTabPage;
		private View.Tabs.ItemsTab itemsTab1;
	}
}

