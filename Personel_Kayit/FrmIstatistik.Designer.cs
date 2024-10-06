namespace Personel_Kayit
{
    partial class FrmIstatistik
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
            this.lbltoplamPersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEvli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBekar = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaasOrt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaasToplam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı :";
            // 
            // lbltoplamPersonel
            // 
            this.lbltoplamPersonel.AutoSize = true;
            this.lbltoplamPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamPersonel.Location = new System.Drawing.Point(305, 60);
            this.lbltoplamPersonel.Name = "lbltoplamPersonel";
            this.lbltoplamPersonel.Size = new System.Drawing.Size(24, 25);
            this.lbltoplamPersonel.TabIndex = 1;
            this.lbltoplamPersonel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evli Personel Sayısı :";
            // 
            // lblEvli
            // 
            this.lblEvli.AutoSize = true;
            this.lblEvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvli.Location = new System.Drawing.Point(305, 110);
            this.lblEvli.Name = "lblEvli";
            this.lblEvli.Size = new System.Drawing.Size(24, 25);
            this.lblEvli.TabIndex = 3;
            this.lblEvli.Text = "0";
            this.lblEvli.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bekar Personel Sayısı :";
            // 
            // lblBekar
            // 
            this.lblBekar.AutoSize = true;
            this.lblBekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekar.Location = new System.Drawing.Point(305, 160);
            this.lblBekar.Name = "lblBekar";
            this.lblBekar.Size = new System.Drawing.Size(24, 25);
            this.lblBekar.TabIndex = 5;
            this.lblBekar.Text = "0";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(305, 210);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(24, 25);
            this.lblSehir.TabIndex = 7;
            this.lblSehir.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Farklı Şehir Sayısı :";
            // 
            // lblMaasOrt
            // 
            this.lblMaasOrt.AutoSize = true;
            this.lblMaasOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaasOrt.Location = new System.Drawing.Point(305, 310);
            this.lblMaasOrt.Name = "lblMaasOrt";
            this.lblMaasOrt.Size = new System.Drawing.Size(24, 25);
            this.lblMaasOrt.TabIndex = 11;
            this.lblMaasOrt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ortalama Maaş :";
            // 
            // lblMaasToplam
            // 
            this.lblMaasToplam.AutoSize = true;
            this.lblMaasToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaasToplam.Location = new System.Drawing.Point(305, 260);
            this.lblMaasToplam.Name = "lblMaasToplam";
            this.lblMaasToplam.Size = new System.Drawing.Size(24, 25);
            this.lblMaasToplam.TabIndex = 9;
            this.lblMaasToplam.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Toplam Maaş :";
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(462, 408);
            this.Controls.Add(this.lblMaasOrt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaasToplam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBekar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEvli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltoplamPersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIstatistik";
            this.Text = "FrmIstatistik";
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltoplamPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEvli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBekar;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaasOrt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaasToplam;
        private System.Windows.Forms.Label label7;
    }
}