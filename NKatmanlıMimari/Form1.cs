using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> personelListesi = LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = personelListesi;
            //MessageBox.Show("Bilgiler listelendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbxDepartman.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxMaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel yeniPersonel = new EntityPersonel();
            yeniPersonel.PersonelAd = tbxAd.Text;
            yeniPersonel.PersonelSoyad = tbxSoyad.Text;
            yeniPersonel.PersonelSehir = tbxSehir.Text;
            yeniPersonel.PersonelGorev = tbxDepartman.Text;
            yeniPersonel.PersonelMaas = short.Parse(tbxMaas.Text);
            LogicPersonel.LogicLayerPersonelEkleme(yeniPersonel);
            MessageBox.Show("Personel eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            List<EntityPersonel> personelListesi = LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = personelListesi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);
            LogicLayer.LogicPersonel.LogicLayerPersonelSilme(id);
            MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<EntityPersonel> personelListesi = LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = personelListesi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel personel = new EntityPersonel();
            personel.PersonelId = Convert.ToInt32(tbxId.Text);
            personel.PersonelAd = tbxAd.Text;
            personel.PersonelSoyad = tbxSoyad.Text;
            personel.PersonelGorev = tbxDepartman.Text;
            personel.PersonelSehir = tbxSehir.Text;
            personel.PersonelMaas = short.Parse(tbxMaas.Text);
            LogicPersonel.LogicLayerPersonelGuncelle(personel);
            MessageBox.Show("Personel güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<EntityPersonel> personelListesi = LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = personelListesi;
        }
    }
}
