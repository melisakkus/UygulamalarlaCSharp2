namespace DonguPratikleri2
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
            this.btnListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tbxSayi = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tbxFaktöriyelSayisi = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Magenta;
            this.btnListele.Location = new System.Drawing.Point(128, 63);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(110, 46);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(128, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 164);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 ile 10 arasında 3\'e tam bölünen sayılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(411, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "1 ile 100 arasında 5\'e ve 7\'ye tam bölünen sayılar";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(565, 129);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(110, 164);
            this.listBox2.TabIndex = 4;
            // 
            // btnListele2
            // 
            this.btnListele2.BackColor = System.Drawing.Color.Magenta;
            this.btnListele2.Location = new System.Drawing.Point(565, 63);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(110, 46);
            this.btnListele2.TabIndex = 3;
            this.btnListele2.Text = "Listele";
            this.btnListele2.UseVisualStyleBackColor = false;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Klavyeden girilen sayıya kadar yazdır";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(128, 427);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(110, 164);
            this.listBox3.TabIndex = 7;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Magenta;
            this.btnYazdir.Location = new System.Drawing.Point(203, 358);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(110, 46);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // tbxSayi
            // 
            this.tbxSayi.Location = new System.Drawing.Point(51, 368);
            this.tbxSayi.Name = "tbxSayi";
            this.tbxSayi.Size = new System.Drawing.Size(108, 26);
            this.tbxSayi.TabIndex = 9;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(487, 368);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(108, 26);
            this.tbxSayi2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(472, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Klavyeden girilen sayının tam bölenleri";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(487, 427);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(262, 164);
            this.listBox4.TabIndex = 11;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Magenta;
            this.btnBul.Location = new System.Drawing.Point(639, 358);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(110, 46);
            this.btnBul.TabIndex = 10;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Faktöriyel Hesabı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Magenta;
            this.btnHesapla.Location = new System.Drawing.Point(175, 99);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(110, 46);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tbxFaktöriyelSayisi
            // 
            this.tbxFaktöriyelSayisi.Location = new System.Drawing.Point(19, 109);
            this.tbxFaktöriyelSayisi.Name = "tbxFaktöriyelSayisi";
            this.tbxFaktöriyelSayisi.Size = new System.Drawing.Size(108, 26);
            this.tbxFaktöriyelSayisi.TabIndex = 17;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(135, 178);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(69, 20);
            this.lblSonuc.TabIndex = 18;
            this.lblSonuc.Text = "(sonuç)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.tbxFaktöriyelSayisi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(877, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 259);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1247, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.tbxSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox tbxSayi;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox tbxFaktöriyelSayisi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

