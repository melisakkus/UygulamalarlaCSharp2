using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void btnUyeKayıtYap_Click(object sender, EventArgs e)
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            SqlCommand komutKayıtYap = new SqlCommand("Insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@pAd,@pSoyad,@pTc,@pTelefon,@pSifre,@pCinsiyet)", baglanti.Baglanti());
            komutKayıtYap.Parameters.AddWithValue("@pAd", tbxUyeAd.Text);
            komutKayıtYap.Parameters.AddWithValue("@pSoyad", tbxUyeSoyad.Text);
            komutKayıtYap.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);
            komutKayıtYap.Parameters.AddWithValue("@pTelefon", maskedtbxTel.Text);
            komutKayıtYap.Parameters.AddWithValue("@pSifre", tbxUyeSifre.Text);
            komutKayıtYap.Parameters.AddWithValue("@pCinsiyet", cbxCinsiyet.Text);
            komutKayıtYap.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleştirilmiştir. Kullanıcı Ad Soyad: "
                            + tbxUyeAd.Text + " " + tbxUyeSoyad.Text
                            + " Kullanıcı Şifre: " + tbxUyeSifre.Text,
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
