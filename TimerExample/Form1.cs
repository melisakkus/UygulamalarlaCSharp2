using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        private void btnSayac_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi++;
            label1.Text = sayi.ToString();
            if(sayi == 5)
            {
                panel1.BackColor = Color.Green;
            }
            if (sayi == 15)
            {
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Yellow;
            }
            if (sayi == 23)
            {
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel3.BackColor = Color.Red;
            }
            if (sayi == 33)
            {
                sayi = 0;
                panel1.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel3.BackColor = Color.Black;
            }

        }
    }
}
