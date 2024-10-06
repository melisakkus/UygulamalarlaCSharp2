namespace MenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSILoveYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynıYıldızınAltındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzayYolcularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(20, 11, 0, 11);
            this.menuStrip1.Size = new System.Drawing.Size(724, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madMaxToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pSILoveYouToolStripMenuItem,
            this.aynıYıldızınAltındaToolStripMenuItem});
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screamToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duneToolStripMenuItem,
            this.uzayYolcularıToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // madMaxToolStripMenuItem
            // 
            this.madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            this.madMaxToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.madMaxToolStripMenuItem.Text = "Mad Max";
            this.madMaxToolStripMenuItem.Click += new System.EventHandler(this.madMaxToolStripMenuItem_Click);
            // 
            // pSILoveYouToolStripMenuItem
            // 
            this.pSILoveYouToolStripMenuItem.Name = "pSILoveYouToolStripMenuItem";
            this.pSILoveYouToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pSILoveYouToolStripMenuItem.Text = "PS I Love You";
            this.pSILoveYouToolStripMenuItem.Click += new System.EventHandler(this.pSILoveYouToolStripMenuItem_Click);
            // 
            // aynıYıldızınAltındaToolStripMenuItem
            // 
            this.aynıYıldızınAltındaToolStripMenuItem.Name = "aynıYıldızınAltındaToolStripMenuItem";
            this.aynıYıldızınAltındaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aynıYıldızınAltındaToolStripMenuItem.Text = "Aynı Yıldızın Altında";
            this.aynıYıldızınAltındaToolStripMenuItem.Click += new System.EventHandler(this.aynıYıldızınAltındaToolStripMenuItem_Click);
            // 
            // screamToolStripMenuItem
            // 
            this.screamToolStripMenuItem.Name = "screamToolStripMenuItem";
            this.screamToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.screamToolStripMenuItem.Text = "Scream";
            this.screamToolStripMenuItem.Click += new System.EventHandler(this.screamToolStripMenuItem_Click);
            // 
            // duneToolStripMenuItem
            // 
            this.duneToolStripMenuItem.Name = "duneToolStripMenuItem";
            this.duneToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.duneToolStripMenuItem.Text = "Dune";
            this.duneToolStripMenuItem.Click += new System.EventHandler(this.duneToolStripMenuItem_Click);
            // 
            // uzayYolcularıToolStripMenuItem
            // 
            this.uzayYolcularıToolStripMenuItem.Name = "uzayYolcularıToolStripMenuItem";
            this.uzayYolcularıToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.uzayYolcularıToolStripMenuItem.Text = "Uzay Yolcuları";
            this.uzayYolcularıToolStripMenuItem.Click += new System.EventHandler(this.uzayYolcularıToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.yesilToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // yesilToolStripMenuItem
            // 
            this.yesilToolStripMenuItem.Name = "yesilToolStripMenuItem";
            this.yesilToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yesilToolStripMenuItem.Text = "Yesil";
            this.yesilToolStripMenuItem.Click += new System.EventHandler(this.yesilToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(106, 121);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(486, 252);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(315, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILMLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 63F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pSILoveYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynıYıldızınAltındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzayYolcularıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

