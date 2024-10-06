using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Berna", "Aslı" };
            foreach(string kisi in kisiler)
            {
                listBox1.Items.Add(kisi);
            }
        }

        double toplam = 0;
        private void btnSinav_Click(object sender, EventArgs e)
        {
            int[] sinavlar = { 45, 81, 70, 33, 69, 78, 49 };

            listBox2.Items.Add("Sınavdan geçen notlar: ");
            foreach (int sinav in sinavlar)
            {
                if (sinav > 50)
                {
                    listBox2.Items.Add(sinav);

                }
            }
            listBox2.Items.Add(" -------------------- ");
            listBox2.Items.Add("Sınavdan kalan notlar: ");
            foreach (int sinav in sinavlar)
            {
                if (sinav < 50)
                {
                    listBox2.Items.Add(sinav);

                }
            }

            listBox2.Items.Add(" -------------------- ");
            foreach (int sinav in sinavlar)
            {
                toplam = toplam + sinav;
            }

            double ortalama = toplam / sinavlar.Length;
            lblOrt.Text = ortalama.ToString("0.00");
        }

        int adet = 0;
        int toplam2 = 0;
        private void btnList_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 23, 76, 5, 89, 80, 24, 187, 456, 90, 100 };
            listBox3.Items.Add("Aşağıdaki sayılar 4'e tam bölünmektedir : \n");
            foreach(int sayi in sayilar)
            {
                if(sayi % 4 == 0)
                {
                    listBox3.Items.Add(sayi);
                    adet++;
                    toplam2 = toplam2 + sayi;
                }
            }
            lblAdet.Text = adet.ToString() + " adet sayı 4'e tam bölünmektedir."; 
            lblToplam.Text = " Bu sayıların toplamı : " + toplam2.ToString();

        }
    }
}
