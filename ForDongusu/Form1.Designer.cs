namespace ForDongusu
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
            this.btnListeyeYazdir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSayilariYazdır = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListeyeYazdir
            // 
            this.btnListeyeYazdir.Location = new System.Drawing.Point(50, 29);
            this.btnListeyeYazdir.Name = "btnListeyeYazdir";
            this.btnListeyeYazdir.Size = new System.Drawing.Size(123, 70);
            this.btnListeyeYazdir.TabIndex = 0;
            this.btnListeyeYazdir.Text = "Listeye Yazdır";
            this.btnListeyeYazdir.UseVisualStyleBackColor = true;
            this.btnListeyeYazdir.Click += new System.EventHandler(this.btnListeyeYazdir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(25, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 229);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnListeyeYazdir);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeye Yazdır";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.btnSayilariYazdır);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(319, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 364);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sayıları Yazdır";
            // 
            // btnSayilariYazdır
            // 
            this.btnSayilariYazdır.Location = new System.Drawing.Point(50, 29);
            this.btnSayilariYazdır.Name = "btnSayilariYazdır";
            this.btnSayilariYazdır.Size = new System.Drawing.Size(123, 70);
            this.btnSayilariYazdır.TabIndex = 0;
            this.btnSayilariYazdır.Text = "Sayıları Yazdır";
            this.btnSayilariYazdır.UseVisualStyleBackColor = true;
            this.btnSayilariYazdır.Click += new System.EventHandler(this.btnSayilariYazdır_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(25, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 229);
            this.listBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(649, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListeyeYazdir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSayilariYazdır;
        private System.Windows.Forms.ListBox listBox2;
    }
}

