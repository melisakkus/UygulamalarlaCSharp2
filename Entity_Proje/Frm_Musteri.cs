using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje
{
    public partial class Frm_Musteri : Form
    {
        public Frm_Musteri()
        {
            InitializeComponent();
        }
        
        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Musteri.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxMusteriId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxMusteriAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxMusteriSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxMusteriSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxMusteriId.Text);
            var musteri = dbEntityUrunEntities.Tbl_Musteri.Find(id);
            dbEntityUrunEntities.Tbl_Musteri.Remove(musteri);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Seçilen müşteri silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Musteri.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Musteri tbl_Musteri = new Tbl_Musteri();
            tbl_Musteri.MusteriAd = tbxMusteriAd.Text;
            tbl_Musteri.MusteriSoyad = tbxMusteriSoyad.Text;
            tbl_Musteri.MusteriSehir = tbxMusteriSehir.Text;
            dbEntityUrunEntities.Tbl_Musteri.Add(tbl_Musteri);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Musteri.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxMusteriId.Text);
            var musteri = dbEntityUrunEntities.Tbl_Musteri.Find(id);
            musteri.MusteriAd = tbxMusteriAd.Text;
            musteri.MusteriSoyad = tbxMusteriSoyad.Text;
            musteri.MusteriSehir = tbxMusteriSehir.Text;
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Müşteri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Musteri.ToList();
        }

        private void Frm_Musteri_Load(object sender, EventArgs e)
        {

        }
    }
}
