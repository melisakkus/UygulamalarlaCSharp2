namespace KararYapilari
{
    partial class BilgiYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiYarismasi));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblYanlisSayaci = new System.Windows.Forms.Label();
            this.lblDogruSayaci = new System.Windows.Forms.Label();
            this.lblSoruSayac = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblVerilenYanit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(29, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(29, 158);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(237, 53);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(290, 158);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(237, 53);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(29, 228);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(237, 53);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(290, 228);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(237, 53);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(586, 36);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(67, 19);
            this.lblSoruNo.TabIndex = 5;
            this.lblSoruNo.Text = "Soru No:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(561, 74);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(92, 19);
            this.lblDogru.TabIndex = 6;
            this.lblDogru.Text = "Doğru Soru :";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(564, 113);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(89, 19);
            this.lblYanlis.TabIndex = 7;
            this.lblYanlis.Text = "Yanlış Soru :";
            // 
            // lblYanlisSayaci
            // 
            this.lblYanlisSayaci.AutoSize = true;
            this.lblYanlisSayaci.Location = new System.Drawing.Point(672, 113);
            this.lblYanlisSayaci.Name = "lblYanlisSayaci";
            this.lblYanlisSayaci.Size = new System.Drawing.Size(17, 19);
            this.lblYanlisSayaci.TabIndex = 10;
            this.lblYanlisSayaci.Text = "0";
            // 
            // lblDogruSayaci
            // 
            this.lblDogruSayaci.AutoSize = true;
            this.lblDogruSayaci.Location = new System.Drawing.Point(672, 74);
            this.lblDogruSayaci.Name = "lblDogruSayaci";
            this.lblDogruSayaci.Size = new System.Drawing.Size(17, 19);
            this.lblDogruSayaci.TabIndex = 9;
            this.lblDogruSayaci.Text = "0";
            // 
            // lblSoruSayac
            // 
            this.lblSoruSayac.AutoSize = true;
            this.lblSoruSayac.Location = new System.Drawing.Point(672, 36);
            this.lblSoruSayac.Name = "lblSoruSayac";
            this.lblSoruSayac.Size = new System.Drawing.Size(17, 19);
            this.lblSoruSayac.TabIndex = 8;
            this.lblSoruSayac.Text = "0";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.Location = new System.Drawing.Point(568, 152);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(128, 38);
            this.btnSonraki.TabIndex = 11;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(620, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(253, 310);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(49, 19);
            this.lblDogruCevap.TabIndex = 14;
            this.lblDogruCevap.Text = "label7";
            this.lblDogruCevap.Visible = false;
            // 
            // lblVerilenYanit
            // 
            this.lblVerilenYanit.AutoSize = true;
            this.lblVerilenYanit.Location = new System.Drawing.Point(253, 343);
            this.lblVerilenYanit.Name = "lblVerilenYanit";
            this.lblVerilenYanit.Size = new System.Drawing.Size(50, 19);
            this.lblVerilenYanit.TabIndex = 15;
            this.lblVerilenYanit.Text = "label8";
            this.lblVerilenYanit.Visible = false;
            // 
            // BilgiYarismasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(722, 307);
            this.Controls.Add(this.lblVerilenYanit);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblYanlisSayaci);
            this.Controls.Add(this.lblDogruSayaci);
            this.Controls.Add(this.lblSoruSayac);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "BilgiYarismasi";
            this.Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblYanlisSayaci;
        private System.Windows.Forms.Label lblDogruSayaci;
        private System.Windows.Forms.Label lblSoruSayac;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.Label lblVerilenYanit;
    }
}