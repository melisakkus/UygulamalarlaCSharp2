using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxAndListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Zonguldak");
        }

        private void btnYeniSehirEkle_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(tbxYeniSehir.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tbxMeslek.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Aşçı");
            listBox1.Items.Add("Diyetisyen");
            listBox1.Items.Add("Psikolog");
        }

        private void btnBilgiListele_Click(object sender, EventArgs e)
        {
            //listboxBilgiListele.Items.Add(tbxAd.Text);
            //listboxBilgiListele.Items.Add(tbxSoyAd.Text);
            //listboxBilgiListele.Items.Add(tbxMeslek2.Text);
            //listboxBilgiListele.Items.Add(tbxYas.Text);
            //listboxBilgiListele.Items.Add(tbxMaas.Text);
            listboxBilgiListele.Items.Add(tbxAd.Text + " " +tbxSoyAd.Text + " " + tbxMeslek2.Text + " " +
                tbxYas.Text + " " + tbxMaas.Text);

        }
    }
}
