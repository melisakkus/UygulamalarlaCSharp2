using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(tbxSayi1.Text);
                int sayi2 = Convert.ToInt32(tbxSayi2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show("Sonuç : " + toplam.ToString());
            }
            catch
            {
                MessageBox.Show("Değerleri kontrol ediniz.");
            }
        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(tbxSayiEx1.Text);
                int sayi2 = Convert.ToInt32(tbxSayiEx2.Text);
                int carpim = sayi1 * sayi2;
                tbxSonuc.Text = carpim.ToString();
            }
            catch (Exception hata) 
            {
                MessageBox.Show(hata.ToString()); 
            }
            finally
            {
                MessageBox.Show("Finally Bloğu çalıştı");
            }

        }
    }
}
