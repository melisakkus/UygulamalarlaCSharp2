using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ahmet", "Ali", "Aslı", "Ayşe","Hakan" };
            lblEleman.Text = kisiler[1];
        }

        private void btnYazdirInt_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 4, 5, 6, 7, 1, 2, 3 };
            lblElemanInt.Text = sayilar[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] fiyat = { 75.50, 80.90 , 110.50 };
            lblElemanDouble.Text = "Küçük Boy Kahve Fiyatı : " + fiyat[0].ToString("0.00") + " TL";
            lblElemanDouble2.Text = "Orta Boy Kahve Fiyatı : " + fiyat[1].ToString("0.00") + " TL";
            lblElemanDouble3.Text = "Büyük Boy Kahve Fiyatı : " + fiyat[2].ToString("0.00") + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] harf = { 'm', 'e', 'l', 'i', 's', 'a' };
            lblElemanHarf.Text = harf[0].ToString();
        }
    }
}
