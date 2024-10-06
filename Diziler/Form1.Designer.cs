namespace Diziler
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
            this.lblEleman = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblElemanInt = new System.Windows.Forms.Label();
            this.btnYazdirInt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblElemanDouble = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblElemanHarf = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblElemanDouble3 = new System.Windows.Forms.Label();
            this.lblElemanDouble2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEleman
            // 
            this.lblEleman.AutoSize = true;
            this.lblEleman.Location = new System.Drawing.Point(62, 73);
            this.lblEleman.Name = "lblEleman";
            this.lblEleman.Size = new System.Drawing.Size(92, 24);
            this.lblEleman.TabIndex = 0;
            this.lblEleman.Text = "(eleman)";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(63, 130);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(90, 40);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lblEleman);
            this.groupBox1.Controls.Add(this.btnYazdir);
            this.groupBox1.Location = new System.Drawing.Point(31, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dizi Elemanı Yazdırma (String)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblElemanInt);
            this.groupBox2.Controls.Add(this.btnYazdirInt);
            this.groupBox2.Location = new System.Drawing.Point(279, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dizi Elemanı Yazdırma (Int)";
            // 
            // lblElemanInt
            // 
            this.lblElemanInt.AutoSize = true;
            this.lblElemanInt.Location = new System.Drawing.Point(62, 73);
            this.lblElemanInt.Name = "lblElemanInt";
            this.lblElemanInt.Size = new System.Drawing.Size(92, 24);
            this.lblElemanInt.TabIndex = 0;
            this.lblElemanInt.Text = "(eleman)";
            // 
            // btnYazdirInt
            // 
            this.btnYazdirInt.Location = new System.Drawing.Point(63, 130);
            this.btnYazdirInt.Name = "btnYazdirInt";
            this.btnYazdirInt.Size = new System.Drawing.Size(90, 40);
            this.btnYazdirInt.TabIndex = 1;
            this.btnYazdirInt.Text = "Yazdır";
            this.btnYazdirInt.UseVisualStyleBackColor = true;
            this.btnYazdirInt.Click += new System.EventHandler(this.btnYazdirInt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.lblElemanDouble2);
            this.groupBox3.Controls.Add(this.lblElemanDouble3);
            this.groupBox3.Controls.Add(this.lblElemanDouble);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(155, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 239);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dizi Elemanı Yazdırma (Double)";
            // 
            // lblElemanDouble
            // 
            this.lblElemanDouble.AutoSize = true;
            this.lblElemanDouble.Location = new System.Drawing.Point(22, 49);
            this.lblElemanDouble.Name = "lblElemanDouble";
            this.lblElemanDouble.Size = new System.Drawing.Size(92, 24);
            this.lblElemanDouble.TabIndex = 0;
            this.lblElemanDouble.Text = "(eleman)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.lblElemanHarf);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(540, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 239);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dizi Elemanı Yazdırma (Harf)";
            // 
            // lblElemanHarf
            // 
            this.lblElemanHarf.AutoSize = true;
            this.lblElemanHarf.Location = new System.Drawing.Point(62, 73);
            this.lblElemanHarf.Name = "lblElemanHarf";
            this.lblElemanHarf.Size = new System.Drawing.Size(92, 24);
            this.lblElemanHarf.TabIndex = 0;
            this.lblElemanHarf.Text = "(eleman)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yazdır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblElemanDouble3
            // 
            this.lblElemanDouble3.AutoSize = true;
            this.lblElemanDouble3.Location = new System.Drawing.Point(22, 154);
            this.lblElemanDouble3.Name = "lblElemanDouble3";
            this.lblElemanDouble3.Size = new System.Drawing.Size(92, 24);
            this.lblElemanDouble3.TabIndex = 2;
            this.lblElemanDouble3.Text = "(eleman)";
            // 
            // lblElemanDouble2
            // 
            this.lblElemanDouble2.AutoSize = true;
            this.lblElemanDouble2.Location = new System.Drawing.Point(22, 99);
            this.lblElemanDouble2.Name = "lblElemanDouble2";
            this.lblElemanDouble2.Size = new System.Drawing.Size(92, 24);
            this.lblElemanDouble2.TabIndex = 3;
            this.lblElemanDouble2.Text = "(eleman)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(792, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Diziler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEleman;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblElemanInt;
        private System.Windows.Forms.Button btnYazdirInt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblElemanDouble;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblElemanHarf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblElemanDouble2;
        private System.Windows.Forms.Label lblElemanDouble3;
    }
}

