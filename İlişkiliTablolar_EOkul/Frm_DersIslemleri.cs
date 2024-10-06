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

namespace İlişkiliTablolar_EOkul
{
    public partial class Frm_DersIslemleri : Form
    {
        public Frm_DersIslemleri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();

        private void Frm_DersIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.DersEkle(tbxAd.Text);
            MessageBox.Show("Ders ekleme işlemi tamamlandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(tbxAd.Text, byte.Parse(tbxId.Text));
            MessageBox.Show("Ders güncelleme işlemi tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.DersSilme(byte.Parse(tbxId.Text));
            MessageBox.Show("Ders silme işlemi tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = ds.DersListesi();
        }
    }
}
