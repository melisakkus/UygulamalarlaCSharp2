using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Melisa Akkuş tarafından tasarlanmıştır.","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("C:\\Users\\90505\\Desktop\\Adsız.png");
            System.Diagnostics.Process.Start("mspaint.exe");
        }


    }
}
