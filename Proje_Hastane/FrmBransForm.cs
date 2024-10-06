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
    public partial class FrmBransForm : Form
    {
        public FrmBransForm()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Branslar", baglan.Baglanti());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Baglanti().Close();
        }
        private void FrmBransForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxBransId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxBransAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxBransId.Text = "";
            tbxBransAd.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@pAd) ",baglan.Baglanti());
            komutEkle.Parameters.AddWithValue("@pAd",tbxBransAd.Text);
            komutEkle.ExecuteNonQuery();
            baglan.Baglanti().Close(); 
            Listele();
            MessageBox.Show("Yeni branş başarıyla eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Branslar where BransId = @pId ", baglan.Baglanti());
            komutSil.Parameters.AddWithValue("@pId", tbxBransId.Text);
            komutSil.ExecuteNonQuery();
            baglan.Baglanti().Close();
            Listele();
            MessageBox.Show("Seçilen branş başarıyla silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Branslar set BransAd = @pAd where BransId = @pId", baglan.Baglanti());
            komutGüncelle.Parameters.AddWithValue("@pAd", tbxBransAd.Text);
            komutGüncelle.Parameters.AddWithValue("@pId", tbxBransId.Text);
            komutGüncelle.ExecuteNonQuery();
            baglan.Baglanti().Close();
            Listele();
            MessageBox.Show("Seçilen branş başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
