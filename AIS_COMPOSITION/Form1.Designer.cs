namespace AIS_COMPOSITION
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.BookListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIS_COMPOSITION.Properties.Resources.DOS;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.BackColor = System.Drawing.Color.MediumBlue;
            this.CategoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CategoryListBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 25;
            this.CategoryListBox.Location = new System.Drawing.Point(132, 39);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(120, 329);
            this.CategoryListBox.TabIndex = 1;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // BookListBox
            // 
            this.BookListBox.BackColor = System.Drawing.Color.MediumBlue;
            this.BookListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BookListBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 25;
            this.BookListBox.Location = new System.Drawing.Point(258, 39);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(120, 329);
            this.BookListBox.TabIndex = 2;
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookListBox);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ListBox BookListBox;
    }
}

