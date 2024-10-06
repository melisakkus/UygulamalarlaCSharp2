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
    public partial class DegiskenlerdeDortIslem : Form
    {
        public DegiskenlerdeDortIslem()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam,fark,bolum, carpim;
            sayi1 = Convert.ToInt16(tbxsayi1.Text);
            sayi2 = Convert.ToInt16(tbxsayi2.Text);

            toplam = sayi1 + sayi2;
            lbltoplama.Text = toplam.ToString();

            fark = sayi1 - sayi2;
            lblFarkAl.Text = fark.ToString();

            bolum = sayi1 / sayi2;
            lblBolme.Text = bolum.ToString();

            carpim = sayi1 * sayi2;
            lblCarp.Text = carpim.ToString();

            MessageBox.Show("Hesaplamalar tamamlanmıştır.");
        }
    }
}
