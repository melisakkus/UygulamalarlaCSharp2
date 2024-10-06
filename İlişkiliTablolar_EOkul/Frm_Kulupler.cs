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

namespace İlişkiliTablolar_EOkul
{
    public partial class Frm_Kulupler : Form
    {
        public Frm_Kulupler()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void Frm_Kulupler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Kulupler", baglanti.baglan());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.baglan().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxId.Text = "";
            tbxAd.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Kulupler (KulupAd) values (@pAd)",baglanti.baglan());
            komutEkle.Parameters.AddWithValue("@pAd", tbxAd.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Yeni kulüp eklenmiştir.", "Kulüp İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Kulupler set KulupAd = @pAd where KulupId = @pId", baglanti.baglan());
            komutGuncelle.Parameters.AddWithValue("@pAd", tbxAd.Text);
            komutGuncelle.Parameters.AddWithValue("@pId", tbxId.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Seçilen kulüp güncellenmiştir.", "Kulüp İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Kulupler where KulupId = @pId", baglanti.baglan());
            komutSil.Parameters.AddWithValue("@pId", tbxId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Seçilen kulüp silinmiştir.", "Kulüp İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
