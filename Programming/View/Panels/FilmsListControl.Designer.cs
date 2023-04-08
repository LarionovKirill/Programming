
namespace Programming.View.Panels
{
    partial class FilmsListControl
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
            this.filmsGroupBox = new System.Windows.Forms.GroupBox();
            this.findFilmsButton = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearOfRealeseLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.yearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.filmsListBox = new System.Windows.Forms.ListBox();
            this.filmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmsGroupBox
            // 
            this.filmsGroupBox.Controls.Add(this.findFilmsButton);
            this.filmsGroupBox.Controls.Add(this.ratingLabel);
            this.filmsGroupBox.Controls.Add(this.ratingTextBox);
            this.filmsGroupBox.Controls.Add(this.genreLabel);
            this.filmsGroupBox.Controls.Add(this.yearOfRealeseLabel);
            this.filmsGroupBox.Controls.Add(this.durationLabel);
            this.filmsGroupBox.Controls.Add(this.titleLabel);
            this.filmsGroupBox.Controls.Add(this.genreTextBox);
            this.filmsGroupBox.Controls.Add(this.yearOfReleaseTextBox);
            this.filmsGroupBox.Controls.Add(this.durationTextBox);
            this.filmsGroupBox.Controls.Add(this.titleTextBox);
            this.filmsGroupBox.Controls.Add(this.filmsListBox);
            this.filmsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.filmsGroupBox.Name = "filmsGroupBox";
            this.filmsGroupBox.Size = new System.Drawing.Size(411, 483);
            this.filmsGroupBox.TabIndex = 0;
            this.filmsGroupBox.TabStop = false;
            this.filmsGroupBox.Text = "Films";
            // 
            // findFilmsButton
            // 
            this.findFilmsButton.Location = new System.Drawing.Point(252, 440);
            this.findFilmsButton.Name = "findFilmsButton";
            this.findFilmsButton.Size = new System.Drawing.Size(112, 26);
            this.findFilmsButton.TabIndex = 25;
            this.findFilmsButton.Text = "Find";
            this.findFilmsButton.UseVisualStyleBackColor = true;
            this.findFilmsButton.Click += new System.EventHandler(this.FindFilmWithMaxRating);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(249, 309);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingLabel.TabIndex = 24;
            this.ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(252, 329);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(112, 22);
            this.ratingTextBox.TabIndex = 23;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.GenreTextChanged);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(249, 235);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 22;
            this.genreLabel.Text = "Genre:";
            // 
            // yearOfRealeseLabel
            // 
            this.yearOfRealeseLabel.AutoSize = true;
            this.yearOfRealeseLabel.Location = new System.Drawing.Point(249, 165);
            this.yearOfRealeseLabel.Name = "yearOfRealeseLabel";
            this.yearOfRealeseLabel.Size = new System.Drawing.Size(114, 17);
            this.yearOfRealeseLabel.TabIndex = 21;
            this.yearOfRealeseLabel.Text = "Year of Release:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(249, 93);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(66, 17);
            this.durationLabel.TabIndex = 20;
            this.durationLabel.Text = "Duration:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(249, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Title:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(252, 255);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(112, 22);
            this.genreTextBox.TabIndex = 18;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextChanged);
            // 
            // yearOfReleaseTextBox
            // 
            this.yearOfReleaseTextBox.Location = new System.Drawing.Point(252, 185);
            this.yearOfReleaseTextBox.Name = "yearOfReleaseTextBox";
            this.yearOfReleaseTextBox.Size = new System.Drawing.Size(112, 22);
            this.yearOfReleaseTextBox.TabIndex = 17;
            this.yearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextChanged);
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(252, 113);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(112, 22);
            this.durationTextBox.TabIndex = 16;
            this.durationTextBox.TextChanged += new System.EventHandler(this.DurationTextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(252, 48);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(112, 22);
            this.titleTextBox.TabIndex = 15;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextChanged);
            // 
            // filmsListBox
            // 
            this.filmsListBox.FormattingEnabled = true;
            this.filmsListBox.ItemHeight = 16;
            this.filmsListBox.Location = new System.Drawing.Point(23, 30);
            this.filmsListBox.Name = "filmsListBox";
            this.filmsListBox.Size = new System.Drawing.Size(189, 436);
            this.filmsListBox.TabIndex = 14;
            this.filmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // FilmsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filmsGroupBox);
            this.Name = "FilmsListControl";
            this.Size = new System.Drawing.Size(421, 491);
            this.filmsGroupBox.ResumeLayout(false);
            this.filmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filmsGroupBox;
        private System.Windows.Forms.Button findFilmsButton;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearOfRealeseLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox yearOfReleaseTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ListBox filmsListBox;
    }
}
