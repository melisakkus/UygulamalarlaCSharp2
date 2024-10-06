using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Example2Indirim : Form
    {
        public Example2Indirim()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;

            adet = Convert.ToInt16(tbxAdet.Text);
            if(adet == 0 || adet <= 20)
            {
                toplam = (adet * 8) - (adet * 8 * 0.20);
                lblTutar.Text = toplam.ToString() + "TL";

            }
            else if(adet >= 21 || adet <= 40)
            {
                toplam = (adet * 8) - (adet * 8 * 0.40);
                lblTutar.Text = toplam.ToString() + "TL";

            }
            else if (adet >= 41)
            {
                toplam = (adet * 8) - (adet * 8 * 0.50);
                lblTutar.Text = toplam.ToString() + "TL";
            }

        }
    }
}
