using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komutGirisYap = new SqlCommand("Select * from Tbl_Sekreter where SekreterTc = @pTc and SekreterSifre = @pSifre", baglan.Baglanti());
            komutGirisYap.Parameters.AddWithValue("@pTc",maskedtbxTc.Text);
            komutGirisYap.Parameters.AddWithValue("@pSifre",tbxSifre.Text);

            SqlDataReader dataReader = komutGirisYap.ExecuteReader();

            if(dataReader.Read())
            {
                FrmSekreterDetay sekreterDetay = new FrmSekreterDetay();
                sekreterDetay.SekreterTc = maskedtbxTc.Text;
                sekreterDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgileri");
            }

            baglan.Baglanti().Close();
        }
    }
}
