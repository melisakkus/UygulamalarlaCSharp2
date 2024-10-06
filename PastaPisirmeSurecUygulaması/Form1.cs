using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastaPisirmeSurecUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;

                if (progressBar1.Value % 20 == 10)
                {
                    label1.BackColor = Color.White;
                }
                if (progressBar1.Value % 20 == 0)
                {
                    label1.BackColor = Color.Red;
                }

                if (progressBar1.Value == 100)
                {
                    timer1.Stop(); 
                    MessageBox.Show("Un ve Yumurta Karıştırıldı");
                    timer2.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             progressBar2.Value += 5;
             if(progressBar2.Value % 10 == 0)
             {
                label2.BackColor = Color.Red;
             }
             if (progressBar2.Value % 10 == 5)
             {
                label2.BackColor = Color.White;
             }
             if(progressBar2.Value == 100)
             {
                timer2.Stop();
                MessageBox.Show("Çırpma İşlemi Yapıldı");
                timer3.Start();

             }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar2.Value % 40 == 0)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar2.Value % 40 == 20)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Malzemeler Eklendi ve Karıştırıldı");
                timer4.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.White;
            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Red;
            }

            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pasta Hazır, Afiyet Olsun :)");
            }
        }
    }
}
