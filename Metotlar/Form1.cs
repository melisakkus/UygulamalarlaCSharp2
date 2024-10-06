using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus(); //imleç textbox1e dönsün

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Renklendir()
        {
            textBox1.BackColor = Color.Blue;
            textBox2.BackColor = Color.Bisque;
            textBox3.BackColor = Color.Magenta;
            textBox4.BackColor = Color.Green;
        }

        private void btnRenklendir_Click(object sender, EventArgs e)
        {
            Renklendir();
        }

        void BilgiAl()
        {
            textBox1.Text = "Melisa";
            textBox2.Text = "Akkuş";
            textBox3.Text = "Ankara";
            textBox4.Text = "22";
        }

        private void btnBilgiGir_Click(object sender, EventArgs e)
        {
            BilgiAl();
        }
    }
}
