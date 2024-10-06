namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUyeAd = new System.Windows.Forms.TextBox();
            this.maskedtbxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUyeSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUyeSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedtbxTel = new System.Windows.Forms.MaskedTextBox();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnUyeKayıtYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Üye Paneli";
            // 
            // tbxUyeAd
            // 
            this.tbxUyeAd.Location = new System.Drawing.Point(278, 216);
            this.tbxUyeAd.Name = "tbxUyeAd";
            this.tbxUyeAd.Size = new System.Drawing.Size(209, 26);
            this.tbxUyeAd.TabIndex = 2;
            // 
            // maskedtbxTc
            // 
            this.maskedtbxTc.Location = new System.Drawing.Point(278, 164);
            this.maskedtbxTc.Mask = "00000000000";
            this.maskedtbxTc.Name = "maskedtbxTc";
            this.maskedtbxTc.Size = new System.Drawing.Size(209, 26);
            this.maskedtbxTc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(179, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No :";
            // 
            // tbxUyeSoyad
            // 
            this.tbxUyeSoyad.Location = new System.Drawing.Point(278, 274);
            this.tbxUyeSoyad.Name = "tbxUyeSoyad";
            this.tbxUyeSoyad.Size = new System.Drawing.Size(209, 26);
            this.tbxUyeSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(139, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyad :";
            // 
            // tbxUyeSifre
            // 
            this.tbxUyeSifre.Location = new System.Drawing.Point(278, 432);
            this.tbxUyeSifre.Name = "tbxUyeSifre";
            this.tbxUyeSifre.Size = new System.Drawing.Size(209, 26);
            this.tbxUyeSifre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(154, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(114, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(120, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon :";
            // 
            // maskedtbxTel
            // 
            this.maskedtbxTel.Location = new System.Drawing.Point(278, 320);
            this.maskedtbxTel.Mask = "(999) 000-0000";
            this.maskedtbxTel.Name = "maskedtbxTel";
            this.maskedtbxTel.Size = new System.Drawing.Size(209, 26);
            this.maskedtbxTel.TabIndex = 4;
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(278, 375);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(209, 28);
            this.cbxCinsiyet.TabIndex = 5;
            // 
            // btnUyeKayıtYap
            // 
            this.btnUyeKayıtYap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUyeKayıtYap.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeKayıtYap.Location = new System.Drawing.Point(321, 486);
            this.btnUyeKayıtYap.Name = "btnUyeKayıtYap";
            this.btnUyeKayıtYap.Size = new System.Drawing.Size(123, 54);
            this.btnUyeKayıtYap.TabIndex = 7;
            this.btnUyeKayıtYap.Text = "Kayıt Yap";
            this.btnUyeKayıtYap.UseVisualStyleBackColor = false;
            this.btnUyeKayıtYap.Click += new System.EventHandler(this.btnUyeKayıtYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnUyeKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(582, 583);
            this.Controls.Add(this.btnUyeKayıtYap);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Üye Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUyeAd;
        private System.Windows.Forms.MaskedTextBox maskedtbxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUyeSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUyeSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedtbxTel;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Button btnUyeKayıtYap;
    }
}