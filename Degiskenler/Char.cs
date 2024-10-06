using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Char : Form
    {
        public Char()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char karakter;
            karakter = Convert.ToChar(textBox1.Text);
            label2.Text = karakter.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char harf;
            harf = 'M';
            label4.Text =harf.ToString();
        }
    }
}
