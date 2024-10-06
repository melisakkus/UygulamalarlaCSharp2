namespace ForEach
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
            this.btnListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSinav = new System.Windows.Forms.Button();
            this.lblOrt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(64, 59);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(182, 52);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(64, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 172);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(320, 159);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 172);
            this.listBox2.TabIndex = 3;
            // 
            // btnSinav
            // 
            this.btnSinav.Location = new System.Drawing.Point(320, 59);
            this.btnSinav.Name = "btnSinav";
            this.btnSinav.Size = new System.Drawing.Size(182, 52);
            this.btnSinav.TabIndex = 2;
            this.btnSinav.Text = "Listele";
            this.btnSinav.UseVisualStyleBackColor = true;
            this.btnSinav.Click += new System.EventHandler(this.btnSinav_Click);
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(450, 350);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(52, 24);
            this.lblOrt.TabIndex = 4;
            this.lblOrt.Text = "(ort)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ortalama :";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(653, 350);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(64, 24);
            this.lblAdet.TabIndex = 8;
            this.lblAdet.Text = "(adet)";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(568, 159);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(349, 172);
            this.listBox3.TabIndex = 7;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(568, 59);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(349, 52);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(653, 393);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(89, 24);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "(toplam)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 444);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnSinav);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSinav;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblToplam;
    }
}

