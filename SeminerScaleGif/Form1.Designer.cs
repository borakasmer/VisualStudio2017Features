namespace SeminerScaleGif
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rdGif = new System.Windows.Forms.RadioButton();
            this.rdImage = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.rndWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rndHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Seçin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dosyayı Boyutlandır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(315, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genişlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yükseklik";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(315, 78);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // rdGif
            // 
            this.rdGif.AutoSize = true;
            this.rdGif.Checked = true;
            this.rdGif.Location = new System.Drawing.Point(351, 115);
            this.rdGif.Name = "rdGif";
            this.rdGif.Size = new System.Drawing.Size(38, 17);
            this.rdGif.TabIndex = 7;
            this.rdGif.TabStop = true;
            this.rdGif.Text = "Gif";
            this.rdGif.UseVisualStyleBackColor = true;
            // 
            // rdImage
            // 
            this.rdImage.AutoSize = true;
            this.rdImage.Location = new System.Drawing.Point(451, 115);
            this.rdImage.Name = "rdImage";
            this.rdImage.Size = new System.Drawing.Size(54, 17);
            this.rdImage.TabIndex = 8;
            this.rdImage.Text = "Resim";
            this.rdImage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 74);
            this.button3.TabIndex = 9;
            this.button3.Text = "Otomatik Boyut Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rndWidth
            // 
            this.rndWidth.Location = new System.Drawing.Point(971, 33);
            this.rndWidth.Name = "rndWidth";
            this.rndWidth.Size = new System.Drawing.Size(100, 20);
            this.rndWidth.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genişlik";
            // 
            // rndHeight
            // 
            this.rndHeight.Location = new System.Drawing.Point(971, 78);
            this.rndHeight.Name = "rndHeight";
            this.rndHeight.Size = new System.Drawing.Size(100, 20);
            this.rndHeight.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(901, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yükseklik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 817);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rndHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rndWidth);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rdImage);
            this.Controls.Add(this.rdGif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rdGif;
        private System.Windows.Forms.RadioButton rdImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox rndWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rndHeight;
        private System.Windows.Forms.Label label4;
    }
}

