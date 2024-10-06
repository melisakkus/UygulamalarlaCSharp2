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
    public partial class BilgiYarismasi : Form
    {
        public BilgiYarismasi()
        {
            InitializeComponent();
        }

        int soruSayisi = 0;
        int dogru = 0;
        int yanlis = 0;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruSayisi++;
            lblSoruSayac.Text = soruSayisi.ToString();
            
            if(soruSayisi == 1) 
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblDogruCevap.Text = "1923";
            }
            if (soruSayisi == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgesinde değildir?";
                btnA.Text = "Balıkesir";
                btnB.Text = "Aydın";
                btnC.Text = "Manisa";
                btnD.Text = "Uşak";
                lblDogruCevap.Text = "Balıkesir";
            }
            if (soruSayisi == 3)
            {
                richTextBox1.Text = "Sırça Köşk kitabını kim yazmıştır?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Sabahattin Ali";
                btnC.Text = "Orhan Pamuk";
                btnD.Text = "Orhan Veli";
                lblDogruCevap.Text = "Sabahattin Ali";
                btnSonraki.Text = "Sonuçlar: ";
            }
            if (soruSayisi == 4)
            {
                MessageBox.Show("Sonuçlar : " + lblDogruSayaci.Text + " adet soruyu doğru bildiniz.");
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false; 
            btnSonraki.Enabled = true;

            lblVerilenYanit.Text = btnA.Text;
            if(lblVerilenYanit.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogruSayaci.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlisSayaci.Text = yanlis.ToString();
                pictureBox2.Visible = true;  
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;

            lblVerilenYanit.Text = btnB.Text;
                if (lblVerilenYanit.Text == lblDogruCevap.Text)
                {
                dogru++;
                    lblDogruSayaci.Text = dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    yanlis++;
                    lblYanlisSayaci.Text = yanlis.ToString();
                    pictureBox2.Visible = true;
                }
            }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVerilenYanit.Text = btnC.Text;
            if (lblVerilenYanit.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogruSayaci.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlisSayaci.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVerilenYanit.Text = btnD.Text;
            if (lblVerilenYanit.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogruSayaci.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlisSayaci.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
