namespace Degiskenler
{
    partial class IntegerForm2
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
            this.lblAciklama = new System.Windows.Forms.Label();
            this.tbxYazilan = new System.Windows.Forms.TextBox();
            this.lblYazılanMetin = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblKup = new System.Windows.Forms.Label();
            this.tbxSayi = new System.Windows.Forms.TextBox();
            this.lblAciklama2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAciklama.Location = new System.Drawing.Point(27, 31);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(341, 25);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Kutuya yazılan Değeri Label\'a yazalım";
            // 
            // tbxYazilan
            // 
            this.tbxYazilan.Location = new System.Drawing.Point(32, 78);
            this.tbxYazilan.Name = "tbxYazilan";
            this.tbxYazilan.Size = new System.Drawing.Size(161, 30);
            this.tbxYazilan.TabIndex = 1;
            // 
            // lblYazılanMetin
            // 
            this.lblYazılanMetin.AutoSize = true;
            this.lblYazılanMetin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblYazılanMetin.Location = new System.Drawing.Point(238, 81);
            this.lblYazılanMetin.Name = "lblYazılanMetin";
            this.lblYazılanMetin.Size = new System.Drawing.Size(118, 25);
            this.lblYazılanMetin.TabIndex = 2;
            this.lblYazılanMetin.Text = "girilen değer";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(82, 127);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(168, 32);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(571, 127);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(168, 32);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKup
            // 
            this.lblKup.AutoSize = true;
            this.lblKup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblKup.Location = new System.Drawing.Point(727, 81);
            this.lblKup.Name = "lblKup";
            this.lblKup.Size = new System.Drawing.Size(103, 25);
            this.lblKup.TabIndex = 6;
            this.lblKup.Text = "küp değeri";
            // 
            // tbxSayi
            // 
            this.tbxSayi.Location = new System.Drawing.Point(521, 78);
            this.tbxSayi.Name = "tbxSayi";
            this.tbxSayi.Size = new System.Drawing.Size(161, 30);
            this.tbxSayi.TabIndex = 5;
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.AutoSize = true;
            this.lblAciklama2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAciklama2.Location = new System.Drawing.Point(533, 31);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(268, 25);
            this.lblAciklama2.TabIndex = 4;
            this.lblAciklama2.Text = "Textbox\'a girilen sayının küpü";
            // 
            // IntegerForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1022, 234);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblKup);
            this.Controls.Add(this.tbxSayi);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblYazılanMetin);
            this.Controls.Add(this.tbxYazilan);
            this.Controls.Add(this.lblAciklama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IntegerForm2";
            this.Text = "IntegerForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox tbxYazilan;
        private System.Windows.Forms.Label lblYazılanMetin;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKup;
        private System.Windows.Forms.TextBox tbxSayi;
        private System.Windows.Forms.Label lblAciklama2;
    }
}