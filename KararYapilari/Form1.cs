using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxYaz.Text == "Ali")
            {
                lblIsim.Text = "doğru";
            }
            else
            {
                lblIsim.Text = "yanlış";
            }
        }

        private void lblYazdir2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbxSayiYaz.Text);
            if (sayi == 10)
            {
                lblSayi.Text = "doğru";
            }
            else
            {
                lblSayi.Text = "yanlış";
            }
        }

        private void lblYazdirCiftMi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbxSayiCiftMi.Text);
            if(sayi%2 == 0)
            {
                lblSayiCiftMi.Text = "Sayi Çifttir";
            }
            else
            {
                lblSayiCiftMi.Text = "Sayi Tektir";
            }
        }

        private void btnOnVeCift_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbxOnVeCift.Text);
            if(sayi>=10 && sayi%2 == 0)
            {
                lblOnVeCift.Text = "evet";
            }
            else
            {
                lblOnVeCift.Text = "hayır";
            }
        }
    }
}
