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
    public partial class IntegerForm2 : Form
    {
        public IntegerForm2()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int deger;
            deger = Convert.ToInt16(tbxYazilan.Text);
            lblYazılanMetin.Text = deger.ToString();
            //textboxa girilen değer string
            //labelda gösterilen değer string
            //hesaplama yapmak için int lazım bu yüzden dönüşümler yaptık 
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi,kup;
            sayi = Convert.ToInt16(tbxSayi.Text);
            kup = sayi * sayi * sayi;
            lblKup.Text = kup.ToString();
        }
    }
}
