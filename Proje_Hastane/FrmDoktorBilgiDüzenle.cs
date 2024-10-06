using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string Tc;
        SqlBaglantisi baglan = new SqlBaglantisi();

        public void BilgiAl()
        {
            SqlCommand komutBilgi = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc = @p1", baglan.Baglanti());
            komutBilgi.Parameters.AddWithValue("@p1", maskedtbxTc.Text);
            SqlDataReader reader = komutBilgi.ExecuteReader();
            while (reader.Read())
            {
                tbxUyeAd.Text = reader[1].ToString();
                tbxUyeSoyad.Text = reader[2].ToString();
                cbxBrans.Text = reader[3].ToString();
                tbxUyeSifre.Text = reader[5].ToString();
            }
            baglan.Baglanti().Close();
        }

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedtbxTc.Text = Tc;
            BilgiAl();

            SqlCommand komutBrans = new SqlCommand("Select * from Tbl_Branslar", baglan.Baglanti());
            SqlDataReader reader3 = komutBrans.ExecuteReader();
            while (reader3.Read())
            {
                cbxBrans.Items.Add(reader3[1]);
            }
            baglan.Baglanti().Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@pAd, DoktorSoyad= @pSoyad, DoktorBrans = @pBrans, DoktorSifre = @pSifre where DoktorTc = @pTc", baglan.Baglanti());
            komutGuncelle.Parameters.AddWithValue("@pAd",tbxUyeAd.Text);
            komutGuncelle.Parameters.AddWithValue("@pSoyad",tbxUyeSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@pBrans",cbxBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@pSifre",tbxUyeSifre.Text);
            komutGuncelle.Parameters.AddWithValue("@pTc",maskedtbxTc.Text);
            komutGuncelle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi.","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BilgiAl();
        }

        private void cbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
