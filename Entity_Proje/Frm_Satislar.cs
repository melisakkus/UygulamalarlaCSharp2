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
    public partial class Frm_Satislar : Form
    {
        public Frm_Satislar()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();

        private void Frm_Satislar_Load(object sender, EventArgs e) //*****
        {
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Satis.ToList();

            var urunler = (from x in dbEntityUrunEntities.Tbl_Urun
                           select new
                           {
                               x.UrunId,
                               x.UrunAd
                           }).ToList() ;
            cbxUrunler.DisplayMember = "UrunAd";
            cbxUrunler.ValueMember = "UrunId";
            cbxUrunler.DataSource = urunler;

            var musteri = (from y in dbEntityUrunEntities.Tbl_Musteri
                           select new
                           {
                               y.MusteriId,
                               MusteriAdSoyad =  y.MusteriAd + " " +  y.MusteriSoyad
                           }).ToList();
            cbxMusteri.DisplayMember = "MusteriAdSoyad";
            cbxMusteri.ValueMember = "MusteriId";
            cbxMusteri.DataSource = musteri;

            tbxSatisTarih.Text = DateTime.Now.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxSatisId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cbxUrunler.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cbxMusteri.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxSatisFiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbxSatisTarih.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Satis.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Satis satisTablosu = new Tbl_Satis();
            satisTablosu.Urun = Convert.ToInt32(cbxUrunler.SelectedValue.ToString());
            satisTablosu.Musteri = Convert.ToInt32(cbxMusteri.SelectedValue.ToString());
            satisTablosu.Fiyat = Convert.ToDecimal(tbxSatisFiyat.Text);
            satisTablosu.Tarih = Convert.ToDateTime(tbxSatisTarih.Text);
            dbEntityUrunEntities.Tbl_Satis.Add(satisTablosu);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Yeni satış bilgileri eklendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Satis.ToList();
        }

        private void cbxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {  
            string secilenUrun = cbxUrunler.Text;
            var fiyat = (from z in dbEntityUrunEntities.Tbl_Urun
                         where z.UrunAd == secilenUrun
                         select z.UrunFiyat).FirstOrDefault();
            tbxSatisFiyat.Text = fiyat.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxSatisId.Text);
            var satis = dbEntityUrunEntities.Tbl_Satis.Find(id);
            dbEntityUrunEntities.Tbl_Satis.Remove(satis);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Seçilen müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Satis.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxSatisId.Text);
            var satis = dbEntityUrunEntities.Tbl_Satis.Find(id);
            satis.Urun = Convert.ToInt32(cbxUrunler.SelectedValue.ToString());
            satis.Musteri = Convert.ToInt32(cbxMusteri.SelectedValue.ToString());
            satis.Fiyat = Convert.ToDecimal(tbxSatisFiyat.Text);
            satis.Tarih = Convert.ToDateTime(tbxSatisTarih.Text);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Seçilen müşteri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Satis.ToList();
        }
    }
}
