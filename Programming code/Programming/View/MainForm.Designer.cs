
namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.enumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.weekdayControl1 = new Programming.View.Panels.WeekdayControl();
            this.seasonControl1 = new Programming.View.Panels.SeasonControl();
            this.classes = new System.Windows.Forms.TabPage();
            this.rectangleListControl2 = new Programming.View.Panels.RectangleListControl();
            this.filmsListControl1 = new Programming.View.Panels.FilmsListControl();
            this.Rectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.weekdayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Enums.SuspendLayout();
            this.classes.SuspendLayout();
            this.Rectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums);
            this.tabControl1.Controls.Add(this.classes);
            this.tabControl1.Controls.Add(this.Rectangles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.enumerationsControl1);
            this.Enums.Controls.Add(this.weekdayControl1);
            this.Enums.Controls.Add(this.seasonControl1);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(948, 534);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(29, 17);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(886, 326);
            this.enumerationsControl1.TabIndex = 18;
            // 
            // weekdayControl1
            // 
            this.weekdayControl1.Location = new System.Drawing.Point(30, 349);
            this.weekdayControl1.Name = "weekdayControl1";
            this.weekdayControl1.Size = new System.Drawing.Size(427, 177);
            this.weekdayControl1.TabIndex = 17;
            // 
            // seasonControl1
            // 
            this.seasonControl1.Location = new System.Drawing.Point(474, 350);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(441, 177);
            this.seasonControl1.TabIndex = 16;
            // 
            // classes
            // 
            this.classes.Controls.Add(this.rectangleListControl2);
            this.classes.Controls.Add(this.filmsListControl1);
            this.classes.Location = new System.Drawing.Point(4, 25);
            this.classes.Name = "classes";
            this.classes.Padding = new System.Windows.Forms.Padding(3);
            this.classes.Size = new System.Drawing.Size(948, 534);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = true;
            // 
            // rectangleListControl2
            // 
            this.rectangleListControl2.Location = new System.Drawing.Point(20, 31);
            this.rectangleListControl2.Name = "rectangleListControl2";
            this.rectangleListControl2.Size = new System.Drawing.Size(411, 484);
            this.rectangleListControl2.TabIndex = 3;
            // 
            // filmsListControl1
            // 
            this.filmsListControl1.Location = new System.Drawing.Point(490, 31);
            this.filmsListControl1.Name = "filmsListControl1";
            this.filmsListControl1.Size = new System.Drawing.Size(421, 491);
            this.filmsListControl1.TabIndex = 2;
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles.Location = new System.Drawing.Point(4, 25);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangles.Size = new System.Drawing.Size(948, 534);
            this.Rectangles.TabIndex = 2;
            this.Rectangles.Text = "Rectangles";
            this.Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, -3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(942, 534);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // weekdayBindingSource
            // 
            this.weekdayBindingSource.DataSource = typeof(Programming.Model.Enums.WeekDay);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.classes.ResumeLayout(false);
            this.Rectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weekdayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.BindingSource weekdayBindingSource;
        private System.Windows.Forms.TabPage classes;
        private System.Windows.Forms.TabPage Rectangles;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.FilmsListControl filmsListControl1;
        private Panels.RectangleListControl rectangleListControl2;
        private Panels.SeasonControl seasonControl1;
        private Panels.WeekdayControl weekdayControl1;
        private Panels.EnumerationsControl enumerationsControl1;
    }
}