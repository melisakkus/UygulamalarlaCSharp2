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
using System.Data.Common;

namespace Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string Tc;
        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad ve Tc Bilgilerini Çekme
            lblTcNo.Text = Tc;
            SqlCommand komutAdSoyadAl = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTc = @pTc",baglan.Baglanti());
            komutAdSoyadAl.Parameters.AddWithValue("@pTc",lblTcNo.Text);
            SqlDataReader dataReader = komutAdSoyadAl.ExecuteReader();
            while(dataReader.Read()) 
            {
                lblAd.Text = dataReader[0].ToString();
                lblSoyad.Text = dataReader[1].ToString();
            }
            baglan.Baglanti().Close();

            GeçmişRandevu();

            //Doktor Bilgilerini Çekme
            SqlCommand komutDoktor = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @pBrans",baglan.Baglanti());
            komutDoktor.Parameters.AddWithValue("@pBrans",cbxBrans.Text);
            SqlDataReader dataReader3 = komutDoktor.ExecuteReader();
            while(dataReader3.Read())
            {
                cbxDoktor.Items.Add(dataReader3[0].ToString() + " " + dataReader3[1].ToString());
            }
            baglan.Baglanti().Close();

            //Branş Bilgilerini Çekme
            SqlCommand komutBranslar = new SqlCommand("Select * from Tbl_Branslar", baglan.Baglanti());
            SqlDataReader dataReader2 = komutBranslar.ExecuteReader();
            while (dataReader2.Read())
            {
                cbxBrans.Items.Add(dataReader2[1]);
            }
            baglan.Baglanti().Close();

        }

        //Randevu Geçmişi
        public void GeçmişRandevu()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc = " + lblTcNo.Text, baglan.Baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Baglanti().Close();
        }

        //aktif randevuları görüntüleme
        public void AktifRandevu()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans ='" + cbxBrans.Text + "'and RandevuDoktor ='" + cbxDoktor.Text + "' and RandevuDurum = '" + "false'", baglan.Baglanti());
            dataAdapter.Fill(dataTable);
            dgwAktifRandevular.DataSource = dataTable;
            baglan.Baglanti().Close();
        }



        private void cbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //branşı seçtiğim zaman doktorlar gelsin istiyorum
            cbxDoktor.Items.Clear();
            cbxDoktor.Text = "";
            SqlCommand komutBransinDoktoru = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @p1", baglan.Baglanti());
            komutBransinDoktoru.Parameters.AddWithValue("@p1", cbxBrans.Text);
            SqlDataReader dataReader = komutBransinDoktoru.ExecuteReader();
            while(dataReader.Read())
            {
                cbxDoktor.Items.Add(dataReader[0].ToString() + " " + dataReader[1].ToString());
            }
            baglan.Baglanti().Close();
        }

        private void cbxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktifRandevu();
        }

        private void lnkBilgileriGüncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGüncelle bilgiGüncelle = new FrmBilgiGüncelle();
            bilgiGüncelle.TcNo = Tc;
            bilgiGüncelle.Show();

        }

        private void dgwAktifRandevular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dgwAktifRandevular.SelectedCells[0].RowIndex;
            tbxRandevuId.Text = dgwAktifRandevular.Rows[sayi].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {//randevu güncelliyoruz
            SqlCommand komutRandevuAl = new SqlCommand("Update Tbl_Randevular set RandevuDurum = 1, HastaTc=@pTc, HastaSikayet = @pSikayet " +
                "where RandevuId = @pId",baglan.Baglanti());
            komutRandevuAl.Parameters.AddWithValue("@pTc",lblTcNo.Text);
            komutRandevuAl.Parameters.AddWithValue("@pSikayet",richtbxSikayet.Text);
            komutRandevuAl.Parameters.AddWithValue("@pId",tbxRandevuId.Text);
            komutRandevuAl.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Randevu oluşturulmuştur.","Randevu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            AktifRandevu();
            GeçmişRandevu();
            Temizle();
        }

        public void Temizle()
        {
            tbxRandevuId.Text = "";
            cbxBrans.Text = "";
            cbxDoktor.Text = "";
            richtbxSikayet.Text = "";
        }
    }
}
