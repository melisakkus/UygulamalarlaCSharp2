using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string SekreterTc;
        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = SekreterTc;
            SqlCommand komutSekreterAdSoyad = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTc = @pTc",baglan.Baglanti());
            komutSekreterAdSoyad.Parameters.AddWithValue("@pTc", lblTcNo.Text);
            SqlDataReader dataReader = komutSekreterAdSoyad.ExecuteReader();
            while(dataReader.Read())
            {
                lblAdSoyad.Text = dataReader[0].ToString();
            }
            baglan.Baglanti().Close();

            //branşları combobox'a aktarma
            SqlCommand komutBranslar = new SqlCommand("Select BransAd from Tbl_Branslar",baglan.Baglanti());
            SqlDataReader dataReader2 = komutBranslar.ExecuteReader();
            while (dataReader2.Read())
            {
                cbxBrans.Items.Add(dataReader2[0].ToString());
            }
            baglan.Baglanti().Close();

            //branşları dgw'ye aktarma
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Branslar", baglan.Baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //doktorları dgw'ye aktarma
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar", baglan.Baglanti());
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;

        }

        private void cbxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoktor.Items.Clear();
            SqlCommand komutDoktor = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @pBrans", baglan.Baglanti());
            komutDoktor.Parameters.AddWithValue("@pBrans", cbxBrans.Text);
            SqlDataReader dataReader = komutDoktor.ExecuteReader();
            while (dataReader.Read())
            {
                cbxDoktor.Items.Add(dataReader[0].ToString() + " " +dataReader[1].ToString());
            }
            baglan.Baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutRandevuEkle = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) " +
                "values (@pTarih,@pSaat,@pBrans,@pDoktor)", baglan.Baglanti());
            komutRandevuEkle.Parameters.AddWithValue("@pTarih", maskedtbxTarih.Text);
            komutRandevuEkle.Parameters.AddWithValue("@pSaat", maskedtbxSaat.Text);
            komutRandevuEkle.Parameters.AddWithValue("@pBrans",cbxBrans.Text);
            komutRandevuEkle.Parameters.AddWithValue("@pDoktor",cbxDoktor.Text);
            komutRandevuEkle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutDuyuruEkle = new SqlCommand("Insert into Tbl_Duyurular (Duyuru) values (@pDuyuru)",baglan.Baglanti());
            komutDuyuruEkle.Parameters.AddWithValue("@pDuyuru", richTextBox1.Text);
            komutDuyuruEkle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Duyuru Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktorPaneli = new FrmDoktorPaneli();
            doktorPaneli.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            FrmBransForm bransForm = new FrmBransForm();
            bransForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRandevuListe frmRandevu = new FrmRandevuListe();
            frmRandevu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutRandevuGüncelle = new SqlCommand("Update Tbl_Randevular set " +
                "RandevuTarih =@pTarih ,RandevuSaat = @pSaat ,RandevuBrans = @pBrans ,RandevuDoktor =@pDoktor where RandevuId = @pId", baglan.Baglanti());
            komutRandevuGüncelle.Parameters.AddWithValue("@pTarih", maskedtbxTarih.Text);
            komutRandevuGüncelle.Parameters.AddWithValue("@pSaat", maskedtbxSaat.Text);
            komutRandevuGüncelle.Parameters.AddWithValue("@pBrans", cbxBrans.Text);
            komutRandevuGüncelle.Parameters.AddWithValue("@pDoktor", cbxDoktor.Text);
            komutRandevuGüncelle.Parameters.AddWithValue("@pId", tbxId.Text);
            komutRandevuGüncelle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
