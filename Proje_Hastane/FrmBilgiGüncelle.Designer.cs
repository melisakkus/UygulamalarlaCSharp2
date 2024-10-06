namespace Proje_Hastane
{
    partial class FrmBilgiGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiGüncelle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedtbxTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxUyeSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUyeSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUyeAd = new System.Windows.Forms.TextBox();
            this.maskedtbxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(182, 280);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 41);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(160, 211);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(161, 29);
            this.cbxCinsiyet.TabIndex = 5;
            // 
            // maskedtbxTel
            // 
            this.maskedtbxTel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtbxTel.Location = new System.Drawing.Point(160, 177);
            this.maskedtbxTel.Mask = "(999) 000-0000";
            this.maskedtbxTel.Name = "maskedtbxTel";
            this.maskedtbxTel.Size = new System.Drawing.Size(161, 28);
            this.maskedtbxTel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(73, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telefon :";
            // 
            // tbxUyeSifre
            // 
            this.tbxUyeSifre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeSifre.Location = new System.Drawing.Point(160, 246);
            this.tbxUyeSifre.Name = "tbxUyeSifre";
            this.tbxUyeSifre.Size = new System.Drawing.Size(161, 28);
            this.tbxUyeSifre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(97, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Şifre :";
            // 
            // tbxUyeSoyad
            // 
            this.tbxUyeSoyad.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeSoyad.Location = new System.Drawing.Point(160, 143);
            this.tbxUyeSoyad.Name = "tbxUyeSoyad";
            this.tbxUyeSoyad.Size = new System.Drawing.Size(161, 28);
            this.tbxUyeSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad :";
            // 
            // tbxUyeAd
            // 
            this.tbxUyeAd.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeAd.Location = new System.Drawing.Point(160, 109);
            this.tbxUyeAd.Name = "tbxUyeAd";
            this.tbxUyeAd.Size = new System.Drawing.Size(161, 28);
            this.tbxUyeAd.TabIndex = 2;
            // 
            // maskedtbxTc
            // 
            this.maskedtbxTc.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtbxTc.Location = new System.Drawing.Point(160, 75);
            this.maskedtbxTc.Mask = "00000000000";
            this.maskedtbxTc.Name = "maskedtbxTc";
            this.maskedtbxTc.Size = new System.Drawing.Size(161, 28);
            this.maskedtbxTc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bilgi Güncelleme Paneli";
            // 
            // FrmBilgiGüncelle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(340, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.maskedtbxTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxUyeSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxUyeSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUyeAd);
            this.Controls.Add(this.maskedtbxTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiGüncelle";
            this.Text = "Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmBilgiGüncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedtbxTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxUyeSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUyeSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUyeAd;
        private System.Windows.Forms.MaskedTextBox maskedtbxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}