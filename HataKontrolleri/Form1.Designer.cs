namespace HataKontrolleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla2 = new System.Windows.Forms.Button();
            this.tbxSayiEx1 = new System.Windows.Forms.TextBox();
            this.tbxSayiEx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSonuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1 :";
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Location = new System.Drawing.Point(137, 52);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi1.TabIndex = 1;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(137, 84);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2 :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(137, 120);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 33);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.tbxSayi1);
            this.groupBox1.Controls.Add(this.tbxSayi2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try - Catch :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxSonuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnHesapla2);
            this.groupBox2.Controls.Add(this.tbxSayiEx1);
            this.groupBox2.Controls.Add(this.tbxSayiEx2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exception ve Mesajlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sayı 1 :";
            // 
            // btnHesapla2
            // 
            this.btnHesapla2.Location = new System.Drawing.Point(110, 139);
            this.btnHesapla2.Name = "btnHesapla2";
            this.btnHesapla2.Size = new System.Drawing.Size(102, 35);
            this.btnHesapla2.TabIndex = 4;
            this.btnHesapla2.Text = "Hesapla";
            this.btnHesapla2.UseVisualStyleBackColor = true;
            this.btnHesapla2.Click += new System.EventHandler(this.btnHesapla2_Click);
            // 
            // tbxSayiEx1
            // 
            this.tbxSayiEx1.Location = new System.Drawing.Point(110, 36);
            this.tbxSayiEx1.Name = "tbxSayiEx1";
            this.tbxSayiEx1.Size = new System.Drawing.Size(100, 26);
            this.tbxSayiEx1.TabIndex = 1;
            // 
            // tbxSayiEx2
            // 
            this.tbxSayiEx2.Location = new System.Drawing.Point(110, 68);
            this.tbxSayiEx2.Name = "tbxSayiEx2";
            this.tbxSayiEx2.Size = new System.Drawing.Size(100, 26);
            this.tbxSayiEx2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sayı 2 :";
            // 
            // tbxSonuc
            // 
            this.tbxSonuc.Location = new System.Drawing.Point(110, 104);
            this.tbxSonuc.Name = "tbxSonuc";
            this.tbxSonuc.Size = new System.Drawing.Size(100, 26);
            this.tbxSonuc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sonuç :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hata Yakalama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla2;
        private System.Windows.Forms.TextBox tbxSayiEx1;
        private System.Windows.Forms.TextBox tbxSayiEx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSonuc;
        private System.Windows.Forms.Label label5;
    }
}

