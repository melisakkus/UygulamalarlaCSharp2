using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komutGiris = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc = @pTc and DoktorSifre = @pSifre ", baglan.Baglanti());
            komutGiris.Parameters.AddWithValue("@pTc",maskedtbxTc.Text);
            komutGiris.Parameters.AddWithValue("@pSifre",tbxSifre.Text);
            SqlDataReader reader = komutGiris.ExecuteReader();
            if (reader.Read())
            {
                FrmDoktorDetay doktorDetay = new FrmDoktorDetay();
                doktorDetay.doktorTc = maskedtbxTc.Text;    
                doktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglan.Baglanti().Close();
        }
    }
}
