namespace KararYapilari
{
    partial class Example1
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSinav1 = new System.Windows.Forms.TextBox();
            this.tbxSinav2 = new System.Windows.Forms.TextBox();
            this.tbxProje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSonuclar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınav 1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınav 2 : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(121, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sonuçları Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Geçme Kalma Durumu :";
            // 
            // tbxSinav1
            // 
            this.tbxSinav1.Location = new System.Drawing.Point(196, 40);
            this.tbxSinav1.Name = "tbxSinav1";
            this.tbxSinav1.Size = new System.Drawing.Size(121, 26);
            this.tbxSinav1.TabIndex = 4;
            // 
            // tbxSinav2
            // 
            this.tbxSinav2.Location = new System.Drawing.Point(196, 91);
            this.tbxSinav2.Name = "tbxSinav2";
            this.tbxSinav2.Size = new System.Drawing.Size(121, 26);
            this.tbxSinav2.TabIndex = 5;
            // 
            // tbxProje
            // 
            this.tbxProje.Location = new System.Drawing.Point(196, 147);
            this.tbxProje.Name = "tbxProje";
            this.tbxProje.Size = new System.Drawing.Size(121, 26);
            this.tbxProje.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proje : ";
            // 
            // tbxSonuclar
            // 
            this.tbxSonuclar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSonuclar.Enabled = false;
            this.tbxSonuclar.ForeColor = System.Drawing.Color.Black;
            this.tbxSonuclar.Location = new System.Drawing.Point(196, 289);
            this.tbxSonuclar.Name = "tbxSonuclar";
            this.tbxSonuclar.Size = new System.Drawing.Size(262, 26);
            this.tbxSonuclar.TabIndex = 11;
            // 
            // Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(485, 382);
            this.Controls.Add(this.tbxSonuclar);
            this.Controls.Add(this.tbxProje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSinav2);
            this.Controls.Add(this.tbxSinav1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Examples";
            this.Text = "Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSinav1;
        private System.Windows.Forms.TextBox tbxSinav2;
        private System.Windows.Forms.TextBox tbxProje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSonuclar;
    }
}