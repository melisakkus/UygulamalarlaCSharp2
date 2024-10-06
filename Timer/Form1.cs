using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac == 5)
            {
                // timer1.Stop();
                this.BackColor = Color.Red;
                    //üstünde çalıştığım yer
                    //üstünde çalıştığım yerin arka planı
            }
            if(sayac == 10)
            {
                this.BackColor = Color.Green;
                sayac = 0;
            }
        }
    }
}
