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
    public partial class SwitchCase : Form
    {
        public SwitchCase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1 : label3.Text = "Ocak"; 
                    break;
                case 2:
                    label3.Text = "Şubat";
                    break;
                case 3:
                    label3.Text = "Mart";
                    break;
                case 4:
                    label3.Text = "Nisan";
                    break;
                case 5:
                    label3.Text = "Mayıs";
                    break;
                case 6:
                    label3.Text = "Haziran";
                    break;
                case 7:
                    label3.Text = "Temmuz";
                    break;
                case 8:
                    label3.Text = "Ağustos";
                    break;
                case 9:
                    label3.Text = "Eylül";
                    break;
                case 10:
                    label3.Text = "Ekim";
                    break;
                case 11:
                    label3.Text = "Kasım";
                    break;
                case 12:
                    label3.Text = "Aralık";
                    break;
                default:
                    label3.Text = "Geçersiz Ay"; 
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = tbxMevsim.Text.ToLower();
            switch (mevsim)
            {
                case "ilkbahar":
                    label4.Text = "mart,nisan,mayıs"; 
                    break;
                case "kış":
                    label4.Text = "aralık, ocak, şubat";
                    break;
                case "sonbahar":
                    label4.Text = "eylül, ekim, kasım";
                    break;
                case "yaz":
                    label4.Text = "haziran, temmuz, ağustos";
                    break;
                default: label4.Text = "geçersiz mevsim."; break;
            }
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            string sembol = tbxIslem.Text;
            sayi1 = Convert.ToInt16(tbxSayi1.Text);
            sayi2 = Convert.ToInt16(tbxSayi2.Text);
            switch (sembol)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    lblSonuc.Text = sonuc.ToString(); break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    lblSonuc.Text = sonuc.ToString(); break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    lblSonuc.Text = sonuc.ToString(); break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    lblSonuc.Text = sonuc.ToString(); break;
            }
        }
    }
}
