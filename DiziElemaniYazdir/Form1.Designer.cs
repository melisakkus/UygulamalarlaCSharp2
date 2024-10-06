namespace DiziElemaniYazdir
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
            this.btnDiziYazdir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSayiYazdir = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnYazdir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiziYazdir
            // 
            this.btnDiziYazdir.Location = new System.Drawing.Point(30, 85);
            this.btnDiziYazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiziYazdir.Name = "btnDiziYazdir";
            this.btnDiziYazdir.Size = new System.Drawing.Size(276, 52);
            this.btnDiziYazdir.TabIndex = 0;
            this.btnDiziYazdir.Text = "Diziyi Yazdır";
            this.btnDiziYazdir.UseVisualStyleBackColor = true;
            this.btnDiziYazdir.Click += new System.EventHandler(this.btnDiziYazdir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(30, 174);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 172);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(332, 174);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(275, 172);
            this.listBox2.TabIndex = 3;
            // 
            // btnSayiYazdir
            // 
            this.btnSayiYazdir.Location = new System.Drawing.Point(332, 85);
            this.btnSayiYazdir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayiYazdir.Name = "btnSayiYazdir";
            this.btnSayiYazdir.Size = new System.Drawing.Size(276, 52);
            this.btnSayiYazdir.TabIndex = 2;
            this.btnSayiYazdir.Text = "Diziyi Yazdır";
            this.btnSayiYazdir.UseVisualStyleBackColor = true;
            this.btnSayiYazdir.Click += new System.EventHandler(this.btnSayiYazdir_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(640, 174);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(275, 172);
            this.listBox3.TabIndex = 5;
            // 
            // btnYazdir2
            // 
            this.btnYazdir2.Location = new System.Drawing.Point(640, 85);
            this.btnYazdir2.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazdir2.Name = "btnYazdir2";
            this.btnYazdir2.Size = new System.Drawing.Size(276, 52);
            this.btnYazdir2.TabIndex = 4;
            this.btnYazdir2.Text = "Diziyi Yazdır";
            this.btnYazdir2.UseVisualStyleBackColor = true;
            this.btnYazdir2.Click += new System.EventHandler(this.btnYazdir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 380);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnYazdir2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnSayiYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDiziYazdir);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiziYazdir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSayiYazdir;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnYazdir2;
    }
}

