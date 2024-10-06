using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class DoubleDegiskenler : Form
    {
        public DoubleDegiskenler()
        {
            InitializeComponent();
        }

        private void btnSayiAl_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, ortalama;
            sinav1 = 60;
            sinav2 = 70;
            sinav3 = 85;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            lblOrtalama.Text = ortalama.ToString("0.00");
        }

        private void btnSayıyıGir_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = Convert.ToDouble(tbxSayi.Text);
            lblSayi.Text = sayi.ToString("0.000");
                
        }
    }
}
