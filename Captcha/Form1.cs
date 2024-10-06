using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] sembol2 = { "+", "-", "*", "/" ,"#"};

            Random random = new Random();
            int random1, random2, random3;

            random1 = random.Next(0, sembol1.Length);

            random2 = random.Next(0,sembol2.Length);
            random3 = random.Next(0, 10);

            label1.Text = sembol1[random1].ToString() + sembol2[random2].ToString() + random3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // üzerinde çalıştığım formu gizle
        }
    }
}
