using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikAraclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnKonum = new Point(50,20);
            btn.Location = btnKonum;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 75;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblKonum = new Point(150, 40);
            lbl.Location = lblKonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Blue;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            for(int i=1;  i<= 5; i++)
            {
                TextBox tbx = new TextBox();
                Point tbxKonum = new Point(300, i*30);
                tbx.Location = tbxKonum;
                tbx.Name = "textbox " + i;
                tbx.Text = i.ToString();
                this.Controls.Add(tbx);

            }

        }
    }
}
