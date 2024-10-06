namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRandevuId = new System.Windows.Forms.TextBox();
            this.lblRandevuId = new System.Windows.Forms.Label();
            this.lnkBilgileriGüncelle = new System.Windows.Forms.LinkLabel();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.richtbxSikayet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwAktifRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblTcNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(193, 105);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(98, 24);
            this.lblSoyad.TabIndex = 20;
            this.lblSoyad.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(193, 68);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(98, 24);
            this.lblAd.TabIndex = 17;
            this.lblAd.Text = "-----------";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(193, 31);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(98, 24);
            this.lblTcNo.TabIndex = 16;
            this.lblTcNo.Text = "-----------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.tbxRandevuId);
            this.groupBox2.Controls.Add(this.lblRandevuId);
            this.groupBox2.Controls.Add(this.lnkBilgileriGüncelle);
            this.groupBox2.Controls.Add(this.btnRandevuAl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxDoktor);
            this.groupBox2.Controls.Add(this.richtbxSikayet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxBrans);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 392);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // tbxRandevuId
            // 
            this.tbxRandevuId.Enabled = false;
            this.tbxRandevuId.Location = new System.Drawing.Point(125, 39);
            this.tbxRandevuId.Name = "tbxRandevuId";
            this.tbxRandevuId.Size = new System.Drawing.Size(190, 35);
            this.tbxRandevuId.TabIndex = 1;
            // 
            // lblRandevuId
            // 
            this.lblRandevuId.AutoSize = true;
            this.lblRandevuId.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuId.Location = new System.Drawing.Point(6, 45);
            this.lblRandevuId.Name = "lblRandevuId";
            this.lblRandevuId.Size = new System.Drawing.Size(100, 18);
            this.lblRandevuId.TabIndex = 14;
            this.lblRandevuId.Text = "Randevu Id :";
            // 
            // lnkBilgileriGüncelle
            // 
            this.lnkBilgileriGüncelle.AutoSize = true;
            this.lnkBilgileriGüncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.lnkBilgileriGüncelle.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkBilgileriGüncelle.ForeColor = System.Drawing.Color.Silver;
            this.lnkBilgileriGüncelle.LinkColor = System.Drawing.Color.Silver;
            this.lnkBilgileriGüncelle.Location = new System.Drawing.Point(138, 353);
            this.lnkBilgileriGüncelle.Name = "lnkBilgileriGüncelle";
            this.lnkBilgileriGüncelle.Size = new System.Drawing.Size(153, 18);
            this.lnkBilgileriGüncelle.TabIndex = 6;
            this.lnkBilgileriGüncelle.TabStop = true;
            this.lnkBilgileriGüncelle.Text = "Bilgileri Güncelle";
            this.lnkBilgileriGüncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgileriGüncelle_LinkClicked);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRandevuAl.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.ForeColor = System.Drawing.Color.Silver;
            this.btnRandevuAl.Location = new System.Drawing.Point(133, 303);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(169, 37);
            this.btnRandevuAl.TabIndex = 5;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Şikayet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(43, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor :";
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Location = new System.Drawing.Point(125, 139);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(190, 37);
            this.cbxDoktor.TabIndex = 3;
            this.cbxDoktor.SelectedIndexChanged += new System.EventHandler(this.cbxDoktor_SelectedIndexChanged);
            // 
            // richtbxSikayet
            // 
            this.richtbxSikayet.Location = new System.Drawing.Point(123, 193);
            this.richtbxSikayet.Name = "richtbxSikayet";
            this.richtbxSikayet.Size = new System.Drawing.Size(192, 104);
            this.richtbxSikayet.TabIndex = 4;
            this.richtbxSikayet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(52, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branş :";
            // 
            // cbxBrans
            // 
            this.cbxBrans.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBrans.FormattingEnabled = true;
            this.cbxBrans.Location = new System.Drawing.Point(125, 83);
            this.cbxBrans.Name = "cbxBrans";
            this.cbxBrans.Size = new System.Drawing.Size(190, 37);
            this.cbxBrans.TabIndex = 2;
            this.cbxBrans.SelectedIndexChanged += new System.EventHandler(this.cbxBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(358, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 263);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(733, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwAktifRandevular);
            this.groupBox4.Location = new System.Drawing.Point(361, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(736, 281);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dgwAktifRandevular
            // 
            this.dgwAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwAktifRandevular.Location = new System.Drawing.Point(3, 31);
            this.dgwAktifRandevular.Name = "dgwAktifRandevular";
            this.dgwAktifRandevular.RowHeadersWidth = 62;
            this.dgwAktifRandevular.RowTemplate.Height = 28;
            this.dgwAktifRandevular.Size = new System.Drawing.Size(730, 247);
            this.dgwAktifRandevular.TabIndex = 0;
            this.dgwAktifRandevular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAktifRandevular_CellDoubleClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1119, 577);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richtbxSikayet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBrans;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgwAktifRandevular;
        private System.Windows.Forms.LinkLabel lnkBilgileriGüncelle;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRandevuId;
        private System.Windows.Forms.TextBox tbxRandevuId;
    }
}