namespace MetinBelgesi
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
            this.btnYolSec = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDosyaYolu = new System.Windows.Forms.TextBox();
            this.tbxDosyaAdi = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnYolSec
            // 
            this.btnYolSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolSec.Location = new System.Drawing.Point(574, 92);
            this.btnYolSec.Name = "btnYolSec";
            this.btnYolSec.Size = new System.Drawing.Size(138, 47);
            this.btnYolSec.TabIndex = 0;
            this.btnYolSec.Text = "Yol Seç";
            this.btnYolSec.UseVisualStyleBackColor = true;
            this.btnYolSec.Click += new System.EventHandler(this.btnYolSec_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(574, 145);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(138, 49);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya Yolu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dosya Adı :";
            // 
            // tbxDosyaYolu
            // 
            this.tbxDosyaYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDosyaYolu.Location = new System.Drawing.Point(220, 102);
            this.tbxDosyaYolu.Name = "tbxDosyaYolu";
            this.tbxDosyaYolu.Size = new System.Drawing.Size(281, 30);
            this.tbxDosyaYolu.TabIndex = 4;
            // 
            // tbxDosyaAdi
            // 
            this.tbxDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDosyaAdi.Location = new System.Drawing.Point(220, 158);
            this.tbxDosyaAdi.Name = "tbxDosyaAdi";
            this.tbxDosyaAdi.Size = new System.Drawing.Size(281, 30);
            this.tbxDosyaAdi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 311);
            this.Controls.Add(this.tbxDosyaAdi);
            this.Controls.Add(this.tbxDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnYolSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYolSec;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDosyaYolu;
        private System.Windows.Forms.TextBox tbxDosyaAdi;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

