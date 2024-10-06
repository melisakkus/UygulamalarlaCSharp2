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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Kategori kategoriFormu = new Frm_Kategori();
            kategoriFormu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Urun urunFormu = new Frm_Urun();
            urunFormu.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_Musteri musteriForm = new Frm_Musteri();
            musteriForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_Istatistik frm_Istatistik = new Frm_Istatistik();
            frm_Istatistik.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_Satislar frm_Satislar = new Frm_Satislar();
            frm_Satislar.ShowDialog();
        }
    }
}
