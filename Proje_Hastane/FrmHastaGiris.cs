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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit hastaKayit = new FrmHastaKayit();
            hastaKayit.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komutAdSifreKontrol = new SqlCommand("Select * from Tbl_Hastalar where HastaTc = @pTc and HastaSifre=@pSifre", baglan.Baglanti());
            komutAdSifreKontrol.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);
            komutAdSifreKontrol.Parameters.AddWithValue("@pSifre", tbxSifre.Text);

            SqlDataReader dataReader = komutAdSifreKontrol.ExecuteReader();
            if (dataReader.Read())
            {
                FrmHastaDetay hastaDetay = new FrmHastaDetay();
                hastaDetay.Tc = maskedtbxTc.Text;
                hastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
            baglan.Baglanti().Close();
        }
    }
}
