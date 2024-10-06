using System;
using System.CodeDom;
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
    public partial class IntegerForm : Form
    {
        public IntegerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 5;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan: " + alan + " Çevre" + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kısa : 10 uzun : 20
            int kısaKenar = 10;
            int uzunKenar = 20;
            int cevre = (uzunKenar + kısaKenar) * 2;
            int alan = kısaKenar * uzunKenar;
            label2.Text = "Dikdörtgenin çevresi: " + cevre + " ve alanı: " + alan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = 75;
            sinav2 = 60;
            sinav3 = 85;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label3.Text = "Ortalama: " + ortalama;
        }
    }
}
