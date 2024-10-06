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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenciler formOgrenci = new FrmOgrenciler();
            formOgrenci.Numara = tbxNumara.Text;
            formOgrenci.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Ogretmenler formOgretmen = new Frm_Ogretmenler();
            formOgretmen.OgretmenNo = tbxNumara.Text;
            formOgretmen.Show();
            this.Hide();    
        }
    }
}
