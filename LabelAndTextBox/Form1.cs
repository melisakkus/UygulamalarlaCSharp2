using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAndTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Melisa";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Sabahattin";
            label6.Text = "Ali";
            label3.Text = "Yazar";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label17.Text = textBox2.Text;
            label16.Text = textBox4.Text;
            label18.Text = textBox3.Text;
        }

    }
}
