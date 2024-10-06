using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(10, 20).ToString();
            label2.Text = Toplam(13, 22).ToString();
            label3.Text = Toplam(25, 28).ToString();
        }

        int Kup(int sayi) 
        {
            int kup = sayi * sayi * sayi;
            return kup;
        }

        private void lblKup_Click(object sender, EventArgs e)
        {
            label4.Text = Kup(Convert.ToInt16(textBox1.Text)).ToString();
        }
    }
}
