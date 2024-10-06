using System;
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
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad, meslek;
            adSoyad = "Melisa Akkuş";
            meslek = "Endüstri Mühendisi";
            lblAdSoyAd.Text = adSoyad;
            lblMeslek.Text = meslek;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bilgi = textBox1.Text;
            label1.Text = bilgi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox2.Text;
            listBox1.Items.Add(adsoyad);

            string yas = maskedTextBox1.Text;
            listBox1.Items.Add(yas);

            string meslek = textBox4.Text;
            listBox1.Items.Add(meslek);

            string cinsiyet;

            if (radioButton1.Checked)
            {
                cinsiyet = "kadın";
            }
            else
            {
                cinsiyet = "erkek";
            }
            listBox1.Items.Add(cinsiyet);

        }
    }
}
