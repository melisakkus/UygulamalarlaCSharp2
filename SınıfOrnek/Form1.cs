using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınıfOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Renk = "Siyah";
            car.Hiz = 160;
            car.Motor = 1246.50;
            car.Fiyat = 50000;
            car.Durum = 's';

            car.YIL = -2020;
            car.MARKA = "Golf";

            car.plaka = "34 BV 234";
            car.muayene = 2020;
           

            label1.Text = car.Renk;
            label2.Text = car.Hiz.ToString();
            label3.Text = car.Motor.ToString();
            label4.Text = car.Fiyat.ToString();
            label5.Text = car.Durum.ToString();

            label6.Text = car.YIL.ToString();
            label7.Text = car.MARKA;

            label8.Text = car.NAME;

            label9.Text = car.plaka;
            label10.Text = car.muayene.ToString();

            pictureBox1.BackColor = Color.Blue;
        }
    }
}
