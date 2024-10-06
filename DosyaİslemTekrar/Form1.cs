using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaİslemTekrar
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

        //1- önce dosya oluşturalım : folderbrowser ile kaydedeceğimiz yeri belirleyelim
        string dosyaYolu;
        string dosyaAdi;
        StreamWriter streamWriter;
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                tbxYol.Text = dosyaYolu;
                MessageBox.Show("Dosya Yolu Seçildi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dosyaAdi = tbxAd.Text;
            streamWriter = File.CreateText(dosyaYolu +"\\"+dosyaAdi+".txt");
            streamWriter.Close();
            MessageBox.Show("Dosya Oluşturuldu.");
        }

        //2- Dosyayı Okuyalım : bunun için bir openFileDialog ve okuduklarımızı yazacağımız bir yere ihtiyacımız var
        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string satir = streamReader.ReadLine();
                while( satir != null )
                {
                    richTextBox1.Text = satir;
                    satir = streamReader.ReadLine();
                }
                MessageBox.Show("Okuma Tamamlandı.");
            }
        }
    }
}
