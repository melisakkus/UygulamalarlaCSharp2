namespace ComboBoxAndListBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxYeniSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniSehirEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMeslek = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listboxBilgiListele = new System.Windows.Forms.ListBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxSoyAd = new System.Windows.Forms.TextBox();
            this.tbxMeslek2 = new System.Windows.Forms.TextBox();
            this.tbxYas = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.tbxMaas = new System.Windows.Forms.TextBox();
            this.btnBilgiListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Adana",
            "Bursa",
            "Aydın"});
            this.comboBox1.Location = new System.Drawing.Point(148, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(83, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Şehir Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxYeniSehir
            // 
            this.tbxYeniSehir.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYeniSehir.Location = new System.Drawing.Point(148, 151);
            this.tbxYeniSehir.Name = "tbxYeniSehir";
            this.tbxYeniSehir.Size = new System.Drawing.Size(212, 32);
            this.tbxYeniSehir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Şehir:";
            // 
            // btnYeniSehirEkle
            // 
            this.btnYeniSehirEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYeniSehirEkle.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSehirEkle.Location = new System.Drawing.Point(98, 203);
            this.btnYeniSehirEkle.Name = "btnYeniSehirEkle";
            this.btnYeniSehirEkle.Size = new System.Drawing.Size(190, 46);
            this.btnYeniSehirEkle.TabIndex = 5;
            this.btnYeniSehirEkle.Text = "Yeni Şehri Ekle";
            this.btnYeniSehirEkle.UseVisualStyleBackColor = false;
            this.btnYeniSehirEkle.Click += new System.EventHandler(this.btnYeniSehirEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Öğretmen",
            "Mühendis",
            "Doktor",
            "Hemşire"});
            this.listBox1.Location = new System.Drawing.Point(563, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 148);
            this.listBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(821, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Yeni Meslek Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şehirler :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(440, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Meslekler :";
            // 
            // tbxMeslek
            // 
            this.tbxMeslek.Location = new System.Drawing.Point(821, 37);
            this.tbxMeslek.Name = "tbxMeslek";
            this.tbxMeslek.Size = new System.Drawing.Size(172, 37);
            this.tbxMeslek.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(578, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Meslek Ekle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(39, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ödev";
            // 
            // listboxBilgiListele
            // 
            this.listboxBilgiListele.FormattingEnabled = true;
            this.listboxBilgiListele.ItemHeight = 29;
            this.listboxBilgiListele.Location = new System.Drawing.Point(279, 434);
            this.listboxBilgiListele.Name = "listboxBilgiListele";
            this.listboxBilgiListele.Size = new System.Drawing.Size(381, 91);
            this.listboxBilgiListele.TabIndex = 14;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(130, 345);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(100, 37);
            this.tbxAd.TabIndex = 15;
            // 
            // tbxSoyAd
            // 
            this.tbxSoyAd.Location = new System.Drawing.Point(130, 389);
            this.tbxSoyAd.Name = "tbxSoyAd";
            this.tbxSoyAd.Size = new System.Drawing.Size(100, 37);
            this.tbxSoyAd.TabIndex = 16;
            // 
            // tbxMeslek2
            // 
            this.tbxMeslek2.Location = new System.Drawing.Point(130, 429);
            this.tbxMeslek2.Name = "tbxMeslek2";
            this.tbxMeslek2.Size = new System.Drawing.Size(100, 37);
            this.tbxMeslek2.TabIndex = 17;
            // 
            // tbxYas
            // 
            this.tbxYas.Location = new System.Drawing.Point(130, 473);
            this.tbxYas.Name = "tbxYas";
            this.tbxYas.Size = new System.Drawing.Size(100, 37);
            this.tbxYas.TabIndex = 18;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 345);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(47, 29);
            this.lblAd.TabIndex = 19;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(39, 389);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(89, 29);
            this.lblSoyAd.TabIndex = 20;
            this.lblSoyAd.Text = "Soy Ad:";
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(39, 429);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(91, 29);
            this.lblMeslek.TabIndex = 21;
            this.lblMeslek.Text = "Meslek:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(39, 473);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(58, 29);
            this.lblYas.TabIndex = 22;
            this.lblYas.Text = "Yaş :";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(39, 516);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(78, 29);
            this.lblMaas.TabIndex = 24;
            this.lblMaas.Text = "Maaş :";
            // 
            // tbxMaas
            // 
            this.tbxMaas.Location = new System.Drawing.Point(130, 516);
            this.tbxMaas.Name = "tbxMaas";
            this.tbxMaas.Size = new System.Drawing.Size(100, 37);
            this.tbxMaas.TabIndex = 23;
            // 
            // btnBilgiListele
            // 
            this.btnBilgiListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBilgiListele.Location = new System.Drawing.Point(361, 384);
            this.btnBilgiListele.Name = "btnBilgiListele";
            this.btnBilgiListele.Size = new System.Drawing.Size(214, 38);
            this.btnBilgiListele.TabIndex = 25;
            this.btnBilgiListele.Text = "Bilgileri Listele";
            this.btnBilgiListele.UseVisualStyleBackColor = false;
            this.btnBilgiListele.Click += new System.EventHandler(this.btnBilgiListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.Controls.Add(this.btnBilgiListele);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.tbxMaas);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblMeslek);
            this.Controls.Add(this.lblSoyAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.tbxYas);
            this.Controls.Add(this.tbxMeslek2);
            this.Controls.Add(this.tbxSoyAd);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.listboxBilgiListele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbxMeslek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnYeniSehirEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxYeniSehir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Araç Kullanımları";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxYeniSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniSehirEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMeslek;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listboxBilgiListele;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxSoyAd;
        private System.Windows.Forms.TextBox tbxMeslek2;
        private System.Windows.Forms.TextBox tbxYas;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox tbxMaas;
        private System.Windows.Forms.Button btnBilgiListele;
    }
}

