﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();  
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(openFileDialog.FileName);
            }*/
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(openFileDialog1.FileName);
            }
        }
    }
}
