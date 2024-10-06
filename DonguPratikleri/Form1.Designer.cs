namespace DonguPratikleri
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(132, 83);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(112, 57);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(160, 164);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(62, 20);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "(sonuc)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 ile 10 arasındaki sayıların toplamı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(417, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "1 ile 10 arasındaki çift sayıların toplamı :";
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.Location = new System.Drawing.Point(527, 164);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(62, 20);
            this.lblSonuc2.TabIndex = 4;
            this.lblSonuc2.Text = "(sonuc)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSonuc2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc2;
        private System.Windows.Forms.Button button1;
    }
}

