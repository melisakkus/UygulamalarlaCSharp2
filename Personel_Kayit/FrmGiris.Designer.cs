namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.tbxKullaniciAd = new System.Windows.Forms.TextBox();
            this.tbxKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // tbxKullaniciAd
            // 
            this.tbxKullaniciAd.Location = new System.Drawing.Point(262, 107);
            this.tbxKullaniciAd.Name = "tbxKullaniciAd";
            this.tbxKullaniciAd.Size = new System.Drawing.Size(174, 30);
            this.tbxKullaniciAd.TabIndex = 1;
            // 
            // tbxKullaniciSifre
            // 
            this.tbxKullaniciSifre.Location = new System.Drawing.Point(262, 162);
            this.tbxKullaniciSifre.Name = "tbxKullaniciSifre";
            this.tbxKullaniciSifre.Size = new System.Drawing.Size(174, 30);
            this.tbxKullaniciSifre.TabIndex = 3;
            this.tbxKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(262, 226);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(174, 41);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(613, 315);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKullaniciSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKullaniciAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKullaniciAd;
        private System.Windows.Forms.TextBox tbxKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
    }
}