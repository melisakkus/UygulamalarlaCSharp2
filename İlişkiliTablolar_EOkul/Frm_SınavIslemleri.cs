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
    public partial class Frm_SınavIslemleri : Form
    {
        public Frm_SınavIslemleri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable2TableAdapter notAdapter = new DataSet1TableAdapters.DataTable2TableAdapter();
        Baglanti baglanti = new Baglanti();
        private void Frm_SınavIslemleri_Load(object sender, EventArgs e)
        {
            SqlCommand komutDersler = new SqlCommand("Select * from Tbl_Dersler", baglanti.baglan());
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komutDersler);
            dataAdapter.Fill(dataTable);
            cbxDersId.DisplayMember = "DersAd";
            cbxDersId.ValueMember = "DersId";
            cbxDersId.DataSource = dataTable;
            baglanti.baglan().Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = notAdapter.NotlarGetir(Convert.ToInt16(tbxOgrId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxNotId.Text = dataGridView1.Rows[sayi].Cells[7].Value.ToString();
            cbxDersId.Text = dataGridView1.Rows[sayi].Cells[6].Value.ToString();
            tbxOgrId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxSinav1.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
            tbxSinav2.Text = dataGridView1.Rows[sayi].Cells[2].Value.ToString();
            tbxProje.Text = dataGridView1.Rows[sayi].Cells[3].Value.ToString();
            tbxOrtalama.Text = dataGridView1.Rows[sayi].Cells[4].Value.ToString();
            tbxDurum.Text = dataGridView1.Rows[sayi].Cells[5].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxNotId.Text = "";
            cbxDersId.Text = "";
            tbxOgrId.Text = "";
            tbxSinav1.Text = "";
            tbxSinav2.Text = "";
            tbxProje.Text = "";
            tbxOrtalama.Text = "";
            tbxDurum.Text = "";
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sinav1 = Convert.ToInt16(tbxSinav1.Text);
            int sinav2 = Convert.ToInt16(tbxSinav2.Text);
            int proje = Convert.ToInt16(tbxProje.Text);
            double ortalama = (sinav1 + sinav2 + proje) / 3;

            tbxOrtalama.Text = ortalama.ToString();
            if (ortalama >= 60)
            {
                tbxDurum.Text = "True";
            }
            else
            {
                tbxDurum.Text = "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //notAdapter.NotGuncelle(byte.Parse(cbxDersId.SelectedValue.ToString()), int.Parse(tbxOgrId.Text), byte.Parse(tbxSinav1.Text), byte.Parse(tbxSinav2.Text), byte.Parse(tbxProje.Text), decimal.Parse(tbxOrtalama.Text), bool.Parse(tbxDurum.Text), int.Parse(tbxNotId.Text));
            //MessageBox.Show("Güncelleme yapılmıştır.", "Not İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGridView1.DataSource = notAdapter.NotListesi(Convert.ToInt16(tbxOgrId.Text));

            //notAdapter.NotGuncelle(int.Parse(tbxOgrId.Text), byte.Parse(tbxSinav1.Text), byte.Parse(tbxSinav2.Text), byte.Parse(tbxProje.Text), decimal.Parse(tbxOrtalama.Text), bool.Parse(tbxDurum.Text),cbxDersId.Text, int.Parse(tbxNotId.Text));
            //MessageBox.Show("Güncelleme yapılmıştır.", "Not İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGridView1.DataSource = notAdapter.NotListesi(Convert.ToInt16(tbxOgrId.Text));
            
            
            notAdapter.NotGuncelle(byte.Parse(cbxDersId.SelectedValue.ToString()), int.Parse(tbxOgrId.Text), byte.Parse(tbxSinav1.Text), byte.Parse(tbxSinav2.Text), byte.Parse(tbxProje.Text), decimal.Parse(tbxOrtalama.Text),bool.Parse(tbxDurum.Text), int.Parse(tbxNotId.Text));
            MessageBox.Show("Güncelleme yapılmıştır.", "Not İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = notAdapter.NotlarGetir(Convert.ToInt16(tbxOgrId.Text));
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
        }


    }
}
