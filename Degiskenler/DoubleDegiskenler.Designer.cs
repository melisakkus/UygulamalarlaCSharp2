namespace Degiskenler
{
    partial class DoubleDegiskenler
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
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnSayiAl = new System.Windows.Forms.Button();
            this.btnSayıyıGir = new System.Windows.Forms.Button();
            this.lblSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ortalama Hesaplama : ";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(227, 101);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(101, 25);
            this.lblOrtalama.TabIndex = 1;
            this.lblOrtalama.Text = "(ortalama)";
            // 
            // btnSayiAl
            // 
            this.btnSayiAl.Location = new System.Drawing.Point(62, 90);
            this.btnSayiAl.Name = "btnSayiAl";
            this.btnSayiAl.Size = new System.Drawing.Size(129, 46);
            this.btnSayiAl.TabIndex = 2;
            this.btnSayiAl.Text = "Ortalama";
            this.btnSayiAl.UseVisualStyleBackColor = true;
            this.btnSayiAl.Click += new System.EventHandler(this.btnSayiAl_Click);
            // 
            // btnSayıyıGir
            // 
            this.btnSayıyıGir.Location = new System.Drawing.Point(62, 289);
            this.btnSayıyıGir.Name = "btnSayıyıGir";
            this.btnSayıyıGir.Size = new System.Drawing.Size(137, 44);
            this.btnSayıyıGir.TabIndex = 5;
            this.btnSayıyıGir.Text = "Sayıyı Gir";
            this.btnSayıyıGir.UseVisualStyleBackColor = true;
            this.btnSayıyıGir.Click += new System.EventHandler(this.btnSayıyıGir_Click);
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(227, 277);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(61, 25);
            this.lblSayi.TabIndex = 4;
            this.lblSayi.Text = "(sayi)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Koddan Sayı Alma :";
            // 
            // tbxSayi
            // 
            this.tbxSayi.Location = new System.Drawing.Point(62, 243);
            this.tbxSayi.Name = "tbxSayi";
            this.tbxSayi.Size = new System.Drawing.Size(137, 30);
            this.tbxSayi.TabIndex = 6;
            // 
            // DoubleDegiskenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 439);
            this.Controls.Add(this.tbxSayi);
            this.Controls.Add(this.btnSayıyıGir);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSayiAl);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoubleDegiskenler";
            this.Text = "DoubleDegiskenler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnSayiAl;
        private System.Windows.Forms.Button btnSayıyıGir;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSayi;
    }
}