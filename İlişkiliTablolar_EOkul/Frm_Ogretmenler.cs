using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlişkiliTablolar_EOkul
{
    public partial class Frm_Ogretmenler : Form
    {
        public Frm_Ogretmenler()
        {
            InitializeComponent();
        }

        public string OgretmenNo;
        private void Frm_Ogretmenler_Load(object sender, EventArgs e)
        {

        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            Frm_DersIslemleri dersIslemleri = new Frm_DersIslemleri();
            dersIslemleri.ShowDialog();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri ogrenciIslemleri = new FrmOgrenciIslemleri();
            ogrenciIslemleri.Show();
        }

        private void btnSinavIslemleri_Click(object sender, EventArgs e)
        {
            Frm_SınavIslemleri sınavIslemleri = new Frm_SınavIslemleri();
            sınavIslemleri.Show();
        }

        private void btnOgretmenIslemleri_Click(object sender, EventArgs e)
        {
            Frm_OgretmenIslemleri ogretmenIslemleri = new Frm_OgretmenIslemleri();
            ogretmenIslemleri.Show();
        }

        private void btnKulupIslemleri_Click(object sender, EventArgs e)
        {
            Frm_Kulupler formKulup = new Frm_Kulupler();    
            formKulup.Show();
        }
    }
}
