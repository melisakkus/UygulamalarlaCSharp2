namespace DosyaİslemTekrar
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblYol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYol = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDosyadanOku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYol
            // 
            this.lblYol.AutoSize = true;
            this.lblYol.Location = new System.Drawing.Point(92, 44);
            this.lblYol.Name = "lblYol";
            this.lblYol.Size = new System.Drawing.Size(88, 24);
            this.lblYol.TabIndex = 0;
            this.lblYol.Text = "Dosya Yolu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Adı :";
            // 
            // tbxYol
            // 
            this.tbxYol.Location = new System.Drawing.Point(195, 40);
            this.tbxYol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxYol.Name = "tbxYol";
            this.tbxYol.Size = new System.Drawing.Size(225, 32);
            this.tbxYol.TabIndex = 2;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(195, 90);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(225, 32);
            this.tbxAd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dosya Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dosya Yolu Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(195, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 212);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnDosyadanOku
            // 
            this.btnDosyadanOku.Location = new System.Drawing.Point(475, 207);
            this.btnDosyadanOku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDosyadanOku.Name = "btnDosyadanOku";
            this.btnDosyadanOku.Size = new System.Drawing.Size(124, 49);
            this.btnDosyadanOku.TabIndex = 7;
            this.btnDosyadanOku.Text = "Dosyadan Oku";
            this.btnDosyadanOku.UseVisualStyleBackColor = true;
            this.btnDosyadanOku.Click += new System.EventHandler(this.btnDosyadanOku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Okunulan Metin :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(703, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDosyadanOku);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.tbxYol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblYol);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYol;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDosyadanOku;
        private System.Windows.Forms.Label label1;
    }
}

