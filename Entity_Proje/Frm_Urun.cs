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
    public partial class Frm_Urun : Form
    {
        public Frm_Urun()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Urun.ToList();
            dataGridView1.DataSource = (from x in dbEntityUrunEntities.Tbl_Urun
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.UrunMarka,
                                            x.UrunStok,
                                            x.UrunFiyat,
                                            x.UrunDurum,
                                            //x.UrunKategori
                                            x.Tbl_Kategori.KategoriAd
                                        }).ToList();
            //x. ile x'in bağlı olduğu tabloların bağlı olduğu tablolara da ulaşabilirim
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun tbl_Urun = new Tbl_Urun();
            tbl_Urun.UrunAd = tbxUrunAd.Text;
            tbl_Urun.UrunMarka = tbxUrunMarka.Text;
            tbl_Urun.UrunStok = Convert.ToInt16(tbxUrunStok.Text);
            tbl_Urun.UrunFiyat = Convert.ToDecimal(tbxUrunFiyat.Text);
            tbl_Urun.UrunDurum = true;
            tbl_Urun.UrunKategori = Convert.ToInt32(cbxUrunKategori.SelectedValue.ToString());
            dbEntityUrunEntities.Tbl_Urun.Add(tbl_Urun);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Ekleme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Urun.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            tbxUrunId.Text = dataGridView1.Rows[sayi].Cells[0].Value.ToString();
            tbxUrunAd.Text = dataGridView1.Rows[sayi].Cells[1].Value.ToString();
            tbxUrunMarka.Text = dataGridView1.Rows[sayi].Cells[2].Value.ToString();
            tbxUrunStok.Text = dataGridView1.Rows[sayi].Cells[3].Value.ToString();
            tbxUrunFiyat.Text = dataGridView1.Rows[sayi].Cells[4].Value.ToString();
            tbxUrunDurum.Text = dataGridView1.Rows[sayi].Cells[5].Value.ToString();
            cbxUrunKategori.Text = dataGridView1.Rows[sayi].Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxUrunId.Text);
            var urun = dbEntityUrunEntities.Tbl_Urun.Find(id);
            dbEntityUrunEntities.Tbl_Urun.Remove(urun);
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Silme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Urun.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxUrunId.Text);
            var urun = dbEntityUrunEntities.Tbl_Urun.Find(id);
            urun.UrunAd = tbxUrunAd.Text;
            urun.UrunMarka = tbxUrunMarka.Text;
            urun.UrunStok = Convert.ToInt16(tbxUrunStok.Text);
            urun.UrunFiyat = Convert.ToDecimal(tbxUrunFiyat.Text);
            urun.UrunKategori = Convert.ToInt32(cbxUrunKategori.SelectedValue.ToString());
            dbEntityUrunEntities.SaveChanges();
            MessageBox.Show("Güncelleme işlemi yapıldı");
            dataGridView1.DataSource = dbEntityUrunEntities.Tbl_Urun.ToList();

        }

        private void Frm_Urun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in dbEntityUrunEntities.Tbl_Kategori
                               select new 
                               {
                                   x.KategoriId,
                                   x.KategoriAd 
                               }
                               ).ToList();
            cbxUrunKategori.ValueMember = "KategoriId";
            cbxUrunKategori.DisplayMember = "KategoriAd";
            cbxUrunKategori.DataSource = kategoriler;   
        }
    }
}
