using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonguPratikleri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i%3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%5== 0 && i%7 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbxSayi.Text);
            for(int i = 1; i <= sayi; i++)
            {
                listBox3.Items.Add(i);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(tbxSayi2.Text);
            for(int i = 1;i<=sayi; i++)
            {
                if(sayi % i == 0)
                {
                    listBox4.Items.Add(i + " " + sayi + " sayısının bir bölenidir.");
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(tbxFaktöriyelSayisi.Text);
            int carpim = 1;
            for(int i = 1; i <= sayi; i++)
            {
                carpim = carpim * i;

            }
            lblSonuc.Text = carpim.ToString();
        }
    }
}
