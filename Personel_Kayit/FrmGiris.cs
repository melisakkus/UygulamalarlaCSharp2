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
using System.ComponentModel.Design;

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd = @ad and KullaniciSifre = @sifre ",baglanti);
            komut.Parameters.AddWithValue("@ad",tbxKullaniciAd.Text);
            komut.Parameters.AddWithValue("@sifre",tbxKullaniciSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                FrmAnaForm anaForm = new FrmAnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
            baglanti.Close();
        }
    }
}
