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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void Listele()
        {
            //dgw'nin doldurulması
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Doktorlar", baglan.Baglanti());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Baglanti().Close();
        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            Listele();

            SqlCommand komutBrans = new SqlCommand("Select BransAd from Tbl_Branslar",baglan.Baglanti());
            SqlDataReader reader = komutBrans.ExecuteReader();
            while (reader.Read())
            {
                cbxBrans.Items.Add(reader[0]);
            }
            baglan.Baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            maskedtbxTc.Text = dataGridView1.Rows[sayi].Cells[4].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[sayi].Cells[2].Value.ToString();
            cbxBrans.Text = dataGridView1.Rows[sayi].Cells[3].Value.ToString();
            tbxSifre.Text = dataGridView1.Rows[sayi].Cells[5].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) " +
                "values (@pAd,@pSoyad,@pBrans,@pTc,@pSifre)",baglan.Baglanti());
            komutEkle.Parameters.AddWithValue("@pAd", tbxAd.Text);
            komutEkle.Parameters.AddWithValue("@pSoyad", tbxSoyad.Text);
            komutEkle.Parameters.AddWithValue("@pBrans", cbxBrans.Text);
            komutEkle.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);
            komutEkle.Parameters.AddWithValue("@pSifre", tbxSifre.Text);
            komutEkle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Yeni kişi başarıyla eklendi.","Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc = @pTc ",baglan.Baglanti());
            komutSil.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);
            komutSil.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Seçilen kişi başarıyla silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd = @pAd, DoktorSoyad = @pSoyad," +
                "DoktorBrans = @pBrans, DoktorSifre=@pSifre where DoktorTc=@pTc ",baglan.Baglanti());
            komutGüncelle.Parameters.AddWithValue("@pAd",tbxAd.Text);
            komutGüncelle.Parameters.AddWithValue("@pSoyad",tbxSoyad.Text);
            komutGüncelle.Parameters.AddWithValue("@pBrans",cbxBrans.Text);
            komutGüncelle.Parameters.AddWithValue("@pSifre",tbxSifre.Text);
            komutGüncelle.Parameters.AddWithValue("@pTc", maskedtbxTc.Text);
            komutGüncelle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Seçilen kişi başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
            tbxAd.Text = "";
            tbxSoyad.Text = "";
            cbxBrans.Text = "";
            tbxSifre.Text = "";
            maskedtbxTc.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
        }
    }
}
