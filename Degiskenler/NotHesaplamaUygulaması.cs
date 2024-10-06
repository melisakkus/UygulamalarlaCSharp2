using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class NotHesaplamaUygulaması : Form
    {
        public NotHesaplamaUygulaması()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyAd;
            ad = textBox1.Text;
            soyAd = textBox5.Text;
            listBox1.Items.Add("Öğrenci Ad: "+ ad);
            listBox1.Items.Add("\nÖğrenci Soy Ad: " + soyAd);

            int sinav1, sinav2, proje, ortalama;
            sinav1 = Convert.ToInt16(textBox2.Text);
            sinav2 = Convert.ToInt16(textBox3.Text);
            proje = Convert.ToInt16(textBox4.Text);
            ortalama = (sinav1 + sinav2 + proje ) / 3;
            listBox1.Items.Add("\nÖğrenci Ortalama Notu: " + ortalama);
        }
    }
}
