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
    public partial class FrmBilgiGüncelle : Form
    {
        public FrmBilgiGüncelle()
        {
            InitializeComponent();
        }

        public string TcNo;
        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FrmBilgiGüncelle_Load(object sender, EventArgs e)
        {
            maskedtbxTc.Text = TcNo;
            SqlCommand komutBilgiÇekme = new SqlCommand("Select * from Tbl_Hastalar where HastaTc = @pTc",baglan.Baglanti());
            komutBilgiÇekme.Parameters.AddWithValue("@pTc",maskedtbxTc.Text);
            SqlDataReader dataReader = komutBilgiÇekme.ExecuteReader();
            while(dataReader.Read())
            {
                tbxUyeAd.Text = dataReader[1].ToString();
                tbxUyeSoyad.Text = dataReader[2].ToString();
                maskedtbxTel.Text = dataReader[4].ToString();
                cbxCinsiyet.Text = dataReader[6].ToString();
                tbxUyeSifre.Text = dataReader[5].ToString();
            }
            baglan.Baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutBilgiGüncelle = new SqlCommand("Update Tbl_Hastalar set HastaAd = @pAd, HastaSoyad = @pSoyad, HastaTelefon = @pTel, " +
                "HastaSifre = @pSifre,HastaCinsiyet = @pCinsiyet  where HastaTc = @pTc ", baglan.Baglanti());
            komutBilgiGüncelle.Parameters.AddWithValue("@pAd", tbxUyeAd.Text);
            komutBilgiGüncelle.Parameters.AddWithValue("@pSoyad", tbxUyeSoyad.Text);
            komutBilgiGüncelle.Parameters.AddWithValue("@pTel", maskedtbxTel.Text);
            komutBilgiGüncelle.Parameters.AddWithValue("@pSifre", tbxUyeSifre.Text);
            komutBilgiGüncelle.Parameters.AddWithValue("@pCinsiyet", cbxCinsiyet.Text);
            komutBilgiGüncelle.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);  
            komutBilgiGüncelle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi","Güncelleme Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
