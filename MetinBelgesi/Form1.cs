using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MetinBelgesi
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

        string dosyaAdi;
        string dosyaYolu;
        StreamWriter streamWriter; //akış yazıcısı : dosya oluşturma,dosyaya yazma işlemlerinde kullanılır //using System.IO;
        //dosyayı baştan aşağı inme bir stream, okuma reader, yazma writer


        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                tbxDosyaYolu.Text = dosyaYolu;  
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dosyaAdi = tbxDosyaAdi.Text;
            streamWriter = File.CreateText(dosyaYolu + "\\" + dosyaAdi+ ".txt");
            streamWriter.Close();
            MessageBox.Show("Dosya oluşturuldu.");
        }
    }
}

//bir dosya yolu seçeceğim (buton1), bir dosya adı vereceğim, metin belgesi dosyasıı oluşturacağım
//dosya yolu ; kayıt yolu, nereye kaydedilecek metin belgesi : folderBrowserDialog ile
//doyası adı : metin belgesinin ismi

