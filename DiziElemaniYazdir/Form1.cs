using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziElemaniYazdir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiziYazdir_Click(object sender, EventArgs e)
        {
            string[] sehir = { "Adana", "İstanbul", "İzmir", "Ankara" };
            for(int i = 0; i < sehir.Length; i++)
            {
                listBox1.Items.Add(sehir[i]);
            }
        }

        private void btnSayiYazdir_Click(object sender, EventArgs e)
        {
            int[] sayi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            listBox2.Items.Add("Aşağıdaki sayılar çifttir : ");
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayi[i]);
                }
            }
        }

        private void btnYazdir2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 12, 23, 34, 45, 56, 67, 2, 3, 9, 0 };
            listBox3.Items.Add("İstenilen şarta uyan sayılar : ");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > 10 && dizi[i] % 2 == 0)
                {
                    listBox3.Items.Add(dizi[i]);
                }
            }
        }
    }
}
