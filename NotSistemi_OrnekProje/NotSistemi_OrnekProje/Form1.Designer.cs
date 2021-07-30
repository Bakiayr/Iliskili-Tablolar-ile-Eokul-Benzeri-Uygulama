
namespace NotSistemi_OrnekProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Ogrenci = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ogretmen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Numara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ogretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Ogrenci
            // 
            this.pictureBox_Ogrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Ogrenci.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ogrenci.Image")));
            this.pictureBox_Ogrenci.Location = new System.Drawing.Point(96, 12);
            this.pictureBox_Ogrenci.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_Ogrenci.Name = "pictureBox_Ogrenci";
            this.pictureBox_Ogrenci.Size = new System.Drawing.Size(139, 140);
            this.pictureBox_Ogrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ogrenci.TabIndex = 0;
            this.pictureBox_Ogrenci.TabStop = false;
            this.pictureBox_Ogrenci.Click += new System.EventHandler(this.pictureBox_Ogrenci_Click);
            // 
            // pictureBox_Ogretmen
            // 
            this.pictureBox_Ogretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Ogretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Ogretmen.Image")));
            this.pictureBox_Ogretmen.Location = new System.Drawing.Point(287, 12);
            this.pictureBox_Ogretmen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_Ogretmen.Name = "pictureBox_Ogretmen";
            this.pictureBox_Ogretmen.Size = new System.Drawing.Size(139, 140);
            this.pictureBox_Ogretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ogretmen.TabIndex = 1;
            this.pictureBox_Ogretmen.TabStop = false;
            this.pictureBox_Ogretmen.Click += new System.EventHandler(this.pictureBox_Ogretmen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen";
            // 
            // textBox_Numara
            // 
            this.textBox_Numara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_Numara.Location = new System.Drawing.Point(184, 208);
            this.textBox_Numara.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Numara.Name = "textBox_Numara";
            this.textBox_Numara.Size = new System.Drawing.Size(167, 31);
            this.textBox_Numara.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numara:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Numara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Ogretmen);
            this.Controls.Add(this.pictureBox_Ogrenci);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ogretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Ogrenci;
        private System.Windows.Forms.PictureBox pictureBox_Ogretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Numara;
        private System.Windows.Forms.Label label3;
    }
}

