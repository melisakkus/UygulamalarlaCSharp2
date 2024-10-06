using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Melisa AKKUŞ tarafından yapılmıştır.","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/hEJnMQG9ev8?si=p4RMdfqHHDqxTn87");
            label1.Text = "MAD MAX";
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/CZzW6_hR068?si=T0DmTfTgfTcJNLU5"); 
            label1.Text = "PS I LOVE YOU";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/aQnlngjZG48?si=oqtU1EYE0wWDFtd2");
            label1.Text = "AYNI YILDIZIN ALTINDA";
        }

        private void screamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/beToTslH17s?si=-k5SdcNfR7_m4ogw");
            label1.Text = "SCREAM";
        }

        private void duneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/n9xhJrPXop4?si=brVp6A0ea7u-C_yy");
            label1.Text = "DUNE";
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/7BWWWQzTpNU?si=taEUJcd9cUhAY0if");
            label1.Text = "UZAY YOLCULARI";
        }
    }
}
