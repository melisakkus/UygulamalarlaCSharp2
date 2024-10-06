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
    public partial class Frm_OgretmenIslemleri : Form
    {
        public Frm_OgretmenIslemleri()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void Frm_OgretmenIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Ogretmenler", baglanti.baglan());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.baglan().Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxBrans.Text = "";
            tbxId.Text = "";
            tbxAdSoyad.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Ogretmenler (OgretmenAdSoyad,OgretmenBrans) values (@pAdSoyad,@pBrans)", baglanti.baglan());
            komutEkle.Parameters.AddWithValue("@pAdSoyad", tbxAdSoyad.Text);
            komutEkle.Parameters.AddWithValue("@pBrans", tbxBrans.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Yeni öğretmen eklenmiştir.", "Öğretmen İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxBrans.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
            tbxAdSoyad.Text = dataGridView1.Rows[sayi].Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Ogretmenler set OgretmenAdSoyad = @pAdSoyad, OgretmenBrans = @pBrans where OgretmenId = @pId", baglanti.baglan());
            komutGuncelle.Parameters.AddWithValue("@pAdSoyad", tbxAdSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@pBrans", tbxBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@pId", tbxId.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Seçilen öğretmen güncellenmiştir.", "Öğretmen İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Ogretmenler where OgretmenId = @pId", baglanti.baglan());
            komutSil.Parameters.AddWithValue("@pId", tbxId.Text);
            komutSil.ExecuteNonQuery();
            baglanti.baglan().Close();
            MessageBox.Show("Seçilen öğretmen silinmiştir.", "Öğretmen İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
