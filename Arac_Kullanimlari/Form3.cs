using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBilgileriListele_Click(object sender, EventArgs e)
        {
            listBoxBilgileriListele.Items.Add(maskedtbxTelNo.Text);
            listBoxBilgileriListele.Items.Add(maskedtbxTcNo.Text);
            listBoxBilgileriListele.Items.Add(maskedtbxTarih.Text);
            listBoxBilgileriListele.Items.Add(maskedtbxSaat.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxBilgileriListele.Items.Add(dateTimePicker1.Text);
        }
    }
}
