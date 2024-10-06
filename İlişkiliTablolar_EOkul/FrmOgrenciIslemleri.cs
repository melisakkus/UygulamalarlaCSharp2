using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlişkiliTablolar_EOkul
{
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter dataAdapter = new DataSet1TableAdapters.DataTable1TableAdapter();
        Baglanti baglanti = new Baglanti();

        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataAdapter.OgrenciListele();

            SqlCommand komut = new SqlCommand("Select * from Tbl_Kulupler",baglanti.baglan());
            DataTable dataTable =new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(komut);
            dataAdapter2.Fill(dataTable);
            cbxKulup.DisplayMember = "KulupAd";//gözükecek olan üye, kulup adları görünsün
            cbxKulup.ValueMember = "KulupId";  //değeri, arka plandaki değeri
            cbxKulup.DataSource = dataTable;
        }

        private void btnBilgiAl_Click(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[sayi].Cells[2].Value.ToString();
            cbxKulup.Text = dataGridView1.Rows[sayi].Cells[3].Value.ToString();
            tbxCinsiyet.Text = dataGridView1.Rows[sayi].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataAdapter.OgrenciGuncelle(tbxAd.Text,tbxSoyad.Text,byte.Parse(cbxKulup.SelectedValue.ToString()),tbxCinsiyet.Text, int.Parse(tbxId.Text));
            MessageBox.Show("Seçilen öğrenci güncellenmiştir.", "Öğrenci İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dataAdapter.OgrenciListele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataAdapter.OgrenciEkle(tbxAd.Text,tbxSoyad.Text,byte.Parse(cbxKulup.SelectedValue.ToString()),tbxCinsiyet.Text);
            dataGridView1.DataSource = dataAdapter.OgrenciListele();
            MessageBox.Show("Öğrenci ekleme işlemi yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataAdapter.OgrenciSilme(int.Parse(tbxId.Text));
            MessageBox.Show("Seçilen öğrenci silinmiştir.", "Öğrenci İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dataAdapter.OgrenciListele();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxId.Text = "";
            tbxAd.Text = "";
            tbxSoyad.Text = "";
            cbxKulup.Text = "";
            tbxCinsiyet.Text = "";
        }

        private void cbxKulup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tbxId.Text = cbxKulup.SelectedValue.ToString(); //value değerini yazdırır
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
                dataGridView1.DataSource = dataAdapter.OgrenciAra(tbxAraSozcuk.Text);
        }
    }
}
