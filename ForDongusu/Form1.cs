using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListeyeYazdir_Click(object sender, EventArgs e)
        {
            string aciklama = "Merhaba Ankara";
            for(int i = 1; i<=10; i++)
            {
                listBox1.Items.Add(i+" : "+aciklama);

            }
        }

        private void btnSayilariYazdır_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<= 10; i++)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
