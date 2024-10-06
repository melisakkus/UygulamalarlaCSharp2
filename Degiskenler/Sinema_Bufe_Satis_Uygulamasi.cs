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
    public partial class Sinema_Bufe_Satis_Uygulamasi : Form
    {
        public Sinema_Bufe_Satis_Uygulamasi()
        {
            InitializeComponent();
        }

        int kasa = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int misirAdet, suAdet, cayAdet, biletAdet, toplam ;

            misirAdet = Convert.ToInt16(tbxMisir.Text);
            suAdet = Convert.ToInt16(tbxSu.Text);
            cayAdet = Convert.ToInt16(tbxCay.Text);
            biletAdet = Convert.ToInt16(tbxBilet.Text);

            int misirFiyat, suFiyat, cayFiyat, biletFiyat;
            misirFiyat = 40;
            suFiyat = 5;
            cayFiyat = 10;
            biletFiyat = 30;

            toplam = misirAdet * misirFiyat + suAdet * suFiyat + 
                cayAdet * cayFiyat + biletAdet * biletFiyat;

            kasa = kasa + toplam;

            lblToplamHesabi.Text = toplam.ToString() + " TL";
            lblKasaHesabi.Text = kasa.ToString() + " TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxBilet.Text = "";
            tbxCay.Text = "";
            tbxSu.Text = "";
            tbxMisir.Text = "";

            tbxMisir.Focus();
        }
    }
}
