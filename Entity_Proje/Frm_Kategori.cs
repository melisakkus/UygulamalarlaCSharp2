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
    public partial class Frm_Kategori : Form
    {
        public Frm_Kategori()
        {
            InitializeComponent();
        }
        
        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();
        //Entity Framework ile sql ile bağlantı kurarak oluşturduğum class ve propertylere ulaşabilmek için bu baglanti sınıfının nesnesini oluşturuyorum
            //dbEntityUrunEntities.Tbl_Kategori.ToList();
            //dbEntityUrunEntities.Tbl_Musteri.ToList();
            //dbEntityUrunEntities.Tbl_Satis.ToList();
            //dbEntityUrunEntities.Tbl_Urun.ToList();

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = dbEntityUrunEntities.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //tabloların bağlı olduğu sınıftan hangi tabloya veri ekleyceksem o tablonun
            //nesnini oluşturmalıym
            //dbEntityUrunEntities aracılığıyla tablolara ulaştım,
            //tablodan türettiğim nesneyle de tablonun içerisinde bulunan sütuna ulaşacağım
            Tbl_Kategori tblKategori = new Tbl_Kategori();
            tblKategori.KategoriAd = tbxKategoriAd.Text;
            dbEntityUrunEntities.Tbl_Kategori.Add(tblKategori); //tbl kategori kategoriAD gibi değerleri tutuyor, o değerleri tabloya eklemek istiyorum
            dbEntityUrunEntities.SaveChanges(); //değişiklikleri kaydet, ilgili sorguyu çalıştır                                     anlamına gelir, sql de ki executeNonQuery
            MessageBox.Show("Ekleme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Kategori.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int id = int.Parse(tbxKategoriId.Text);
            var kategori = dbEntityUrunEntities.Tbl_Kategori.Find(id);
            //Entity Framework'te Find() metodu, birincil anahtar (primary key) kullanarak ilgili kaydı bulur ve geri döner.
            dbEntityUrunEntities.Tbl_Kategori.Remove(kategori);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Silme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Kategori.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxKategoriId.Text);
            var kategori = dbEntityUrunEntities.Tbl_Kategori.Find(id);
            kategori.KategoriAd = tbxKategoriAd.Text;
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Güncelleme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Kategori.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxKategoriId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxKategoriAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
        }

        private void Frm_Kategori_Load(object sender, EventArgs e)
        {

        }
    }
}
