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
    public partial class Frm_Istatistik : Form
    {
        public Frm_Istatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();
        private void Frm_Istatistik_Load(object sender, EventArgs e)
        {
            lblToplamKategori.Text = dbEntityUrunEntities.Tbl_Kategori.Count().ToString();
            lblToplamUrun.Text = dbEntityUrunEntities.Tbl_Urun.Count().ToString();
            lblAktifMusteri.Text = dbEntityUrunEntities.Tbl_Musteri.Count(x=>x.MusteriDurum == true).ToString();
            lblPasifMusteri.Text = dbEntityUrunEntities.Tbl_Musteri.Count(x=>x.MusteriDurum == false).ToString();
            lblToplamStok.Text = dbEntityUrunEntities.Tbl_Urun.Sum(x => x.UrunStok).ToString();
            lblEnYuksekFiyat.Text = (from x in dbEntityUrunEntities.Tbl_Urun
                                     orderby x.UrunFiyat descending
                                     select x.UrunAd).FirstOrDefault();
            lblEnDusuk.Text = (from x in dbEntityUrunEntities.Tbl_Urun
                               orderby x.UrunFiyat ascending
                               select x.UrunAd).FirstOrDefault();
            lblBeyazEsya.Text = dbEntityUrunEntities.Tbl_Urun.Count(x=>x.UrunKategori == 1).ToString();
            lblSehirSayisi.Text = (from x in dbEntityUrunEntities.Tbl_Musteri
                                   select x.MusteriSehir).Distinct().Count().ToString();
            lblKasadakiTutar.Text = dbEntityUrunEntities.Tbl_Satis.Sum(x => x.Fiyat).ToString();
            lblToplamBuzdolabi.Text = dbEntityUrunEntities.Tbl_Urun.Count(x => x.UrunAd == "Buzdolabı").ToString();
            lblEnFazlaUrun.Text = dbEntityUrunEntities.MarkaGetir().FirstOrDefault();
        }
    }
}
