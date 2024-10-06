using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusRezarvasyon
{
    public partial class UcusRezervasyon : Form
    {
        public UcusRezervasyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxBilgiler.Items.Add("Yolcu Ad ve Soyad: " + tbxAdSoyad.Text);
            listBoxBilgiler.Items.Add("Yolcu TC No: " + maskedTextBoxTCNo.Text);
            listBoxBilgiler.Items.Add("Yolcu Telefon No: " + maskedTextBoxTelNo.Text);
            listBoxBilgiler.Items.Add("Nereden: "+ cbxNereden.Text);
            listBoxBilgiler.Items.Add("Nereye: " + cbxNereye.Text);
            listBoxBilgiler.Items.Add("Tarih: " + dateTimePicker1.Text);
            listBoxBilgiler.Items.Add("Saat: " + maskedTextBoxSaat.Text);
            MessageBox.Show("Uçuş Kartınız hazırlanmıştır, İyi yolcululklar dileriz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nereden = cbxNereden.Text;
            cbxNereden.Text = cbxNereye.Text;
            cbxNereye.Text = nereden;

        }
    }
}
