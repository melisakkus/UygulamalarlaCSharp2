namespace Arac_Kullanimlari
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.maskedtbxTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.maskedtbxTcNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.maskedtbxTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.maskedtbxSaat = new System.Windows.Forms.MaskedTextBox();
            this.btnBilgileriListele = new System.Windows.Forms.Button();
            this.listBoxBilgileriListele = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedtbxTelNo
            // 
            this.maskedtbxTelNo.Location = new System.Drawing.Point(220, 74);
            this.maskedtbxTelNo.Mask = "(999) 000-0000";
            this.maskedtbxTelNo.Name = "maskedtbxTelNo";
            this.maskedtbxTelNo.Size = new System.Drawing.Size(197, 30);
            this.maskedtbxTelNo.TabIndex = 0;
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(75, 74);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(114, 25);
            this.lblTelefonNo.TabIndex = 1;
            this.lblTelefonNo.Text = "Telefon No:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(75, 145);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(76, 25);
            this.lblTCNo.TabIndex = 3;
            this.lblTCNo.Text = "TC No:";
            // 
            // maskedtbxTcNo
            // 
            this.maskedtbxTcNo.Location = new System.Drawing.Point(220, 145);
            this.maskedtbxTcNo.Mask = "00000000000";
            this.maskedtbxTcNo.Name = "maskedtbxTcNo";
            this.maskedtbxTcNo.Size = new System.Drawing.Size(197, 30);
            this.maskedtbxTcNo.TabIndex = 2;
            this.maskedtbxTcNo.ValidatingType = typeof(int);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(75, 217);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(63, 25);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih:";
            // 
            // maskedtbxTarih
            // 
            this.maskedtbxTarih.Location = new System.Drawing.Point(220, 217);
            this.maskedtbxTarih.Mask = "00/00/0000";
            this.maskedtbxTarih.Name = "maskedtbxTarih";
            this.maskedtbxTarih.Size = new System.Drawing.Size(197, 30);
            this.maskedtbxTarih.TabIndex = 4;
            this.maskedtbxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(75, 293);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(59, 25);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat:";
            // 
            // maskedtbxSaat
            // 
            this.maskedtbxSaat.Location = new System.Drawing.Point(220, 293);
            this.maskedtbxSaat.Mask = "00:00";
            this.maskedtbxSaat.Name = "maskedtbxSaat";
            this.maskedtbxSaat.Size = new System.Drawing.Size(197, 30);
            this.maskedtbxSaat.TabIndex = 6;
            this.maskedtbxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // btnBilgileriListele
            // 
            this.btnBilgileriListele.Location = new System.Drawing.Point(502, 145);
            this.btnBilgileriListele.Name = "btnBilgileriListele";
            this.btnBilgileriListele.Size = new System.Drawing.Size(153, 57);
            this.btnBilgileriListele.TabIndex = 8;
            this.btnBilgileriListele.Text = "Bilgileri Listele";
            this.btnBilgileriListele.UseVisualStyleBackColor = true;
            this.btnBilgileriListele.Click += new System.EventHandler(this.btnBilgileriListele_Click);
            // 
            // listBoxBilgileriListele
            // 
            this.listBoxBilgileriListele.FormattingEnabled = true;
            this.listBoxBilgileriListele.ItemHeight = 25;
            this.listBoxBilgileriListele.Location = new System.Drawing.Point(685, 124);
            this.listBoxBilgileriListele.Name = "listBoxBilgileriListele";
            this.listBoxBilgileriListele.Size = new System.Drawing.Size(259, 204);
            this.listBoxBilgileriListele.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tarih Bilgisini Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxBilgileriListele);
            this.Controls.Add(this.btnBilgileriListele);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.maskedtbxSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.maskedtbxTarih);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.maskedtbxTcNo);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.maskedtbxTelNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtbxTelNo;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.MaskedTextBox maskedtbxTcNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.MaskedTextBox maskedtbxTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.MaskedTextBox maskedtbxSaat;
        private System.Windows.Forms.Button btnBilgileriListele;
        private System.Windows.Forms.ListBox listBoxBilgileriListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}