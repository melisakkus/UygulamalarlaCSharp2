using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities dbEntityUrunEntities = new DbEntityUrunEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var admin = from x in dbEntityUrunEntities.Tbl_Admin
                        where x.adminAd == tbxAd.Text && 
                              x.adminSifre == tbxSifre.Text
                        select x;
            if (admin.Any()) //  admin bir değer döndürüyorsa
            {
                Form1 form1 = new Form1();  
                form1.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
