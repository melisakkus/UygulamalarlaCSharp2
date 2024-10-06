using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, proje, hesap , gecmePuani;
            sinav1 = Convert.ToDouble(tbxSinav1.Text);
            sinav2 = Convert.ToDouble(tbxSinav2.Text);
            proje = Convert.ToDouble(tbxProje.Text);
            gecmePuani = 65;
            hesap = (sinav1 + sinav2 + proje) / 3;
            string yazdirHesap = hesap.ToString("0.00");
            if(hesap>= gecmePuani)
            {
                tbxSonuclar.Text = $"Ortalamanız : {yazdirHesap}  Geçtiniz :)";
            }
            else
            {
                tbxSonuclar.Text = $"Ortalamanız : {yazdirHesap}  Kaldınız :(";
            }
        }
    }
}
