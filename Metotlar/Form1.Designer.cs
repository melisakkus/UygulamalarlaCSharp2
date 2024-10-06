namespace Metotlar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRenklendir = new System.Windows.Forms.Button();
            this.btnBilgiGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 30);
            this.textBox1.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(165, 307);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(145, 38);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 30);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 30);
            this.textBox4.TabIndex = 4;
            // 
            // btnRenklendir
            // 
            this.btnRenklendir.Location = new System.Drawing.Point(165, 360);
            this.btnRenklendir.Name = "btnRenklendir";
            this.btnRenklendir.Size = new System.Drawing.Size(145, 38);
            this.btnRenklendir.TabIndex = 5;
            this.btnRenklendir.Text = "Renklendir";
            this.btnRenklendir.UseVisualStyleBackColor = true;
            this.btnRenklendir.Click += new System.EventHandler(this.btnRenklendir_Click);
            // 
            // btnBilgiGir
            // 
            this.btnBilgiGir.Location = new System.Drawing.Point(165, 415);
            this.btnBilgiGir.Name = "btnBilgiGir";
            this.btnBilgiGir.Size = new System.Drawing.Size(145, 33);
            this.btnBilgiGir.TabIndex = 6;
            this.btnBilgiGir.Text = "Bilgi Gir";
            this.btnBilgiGir.UseVisualStyleBackColor = true;
            this.btnBilgiGir.Click += new System.EventHandler(this.btnBilgiGir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 530);
            this.Controls.Add(this.btnBilgiGir);
            this.Controls.Add(this.btnRenklendir);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRenklendir;
        private System.Windows.Forms.Button btnBilgiGir;
    }
}

