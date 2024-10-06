using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
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
            Random random = new Random();
            int sayi1,sayi2,sayi3,sayi4;

            sayi1 = random.Next(1, 4);
            label1.Text = sayi1.ToString();
            sayi2 = random.Next(1, 4);
            label2.Text = sayi2.ToString();
            sayi3 = random.Next(1, 4);
            label3.Text = sayi3.ToString();
            sayi4 = random.Next(1, 4);
            label4.Text = sayi4.ToString();

            if(label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            //if (sayi1 == Convert.ToInt16(textBox1.Text) && sayi2 == Convert.ToInt16(textBox2.Text) &&
            //    sayi3 == Convert.ToInt16(textBox3.Text) && sayi4 == Convert.ToInt16(textBox4.Text))
            //{
            //    this.BackColor = Color.Green;
            //}
            //else
            //{
            //    this.BackColor = Color.Red;
            //}
        }
    }
}
