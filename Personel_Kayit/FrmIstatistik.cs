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

namespace Personel_Kayit
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglanti);
            SqlDataReader dataReader = komut1.ExecuteReader();
            while (dataReader.Read())
            {
                lbltoplamPersonel.Text = dataReader[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum = 1 ", baglanti);
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                lblEvli.Text = dataReader2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum = 0",baglanti);
            SqlDataReader dataReader3 = komut3.ExecuteReader();
            while (dataReader3.Read())
            {
                lblBekar.Text = dataReader3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(Distinct (PerSehir)) from Tbl_Personel",baglanti);
            SqlDataReader dataReader4 = komut4.ExecuteReader();
            while (dataReader4.Read())
            {
                lblSehir .Text = dataReader4[0].ToString();
            }
            baglanti .Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dataRedear5 = komut5.ExecuteReader();
            while (dataRedear5.Read())
            {
                lblMaasToplam.Text = dataRedear5[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dataReader6 = komut6.ExecuteReader();
            while (dataReader6.Read())
            {
                lblMaasOrt.Text = dataReader6[0].ToString();    
            }
            baglanti.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
