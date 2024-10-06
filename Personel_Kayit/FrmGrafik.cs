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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) from Tbl_Personel Group By PerSehir",baglanti);
            SqlDataReader dataReader = komutg1.ExecuteReader();
            while(dataReader.Read()) 
            {
                chart1.Series["Sehirler"].Points.AddXY(dataReader[0], dataReader[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) from Tbl_Personel group by PerMeslek",baglanti);
            SqlDataReader dataReader2 = komutg2.ExecuteReader();
            while (dataReader2.Read())
            {
                chart2.Series["Meslek - Maas"].Points.AddXY(dataReader2[0], dataReader2[1]);
            }
            baglanti.Close();
        }
    }
}
