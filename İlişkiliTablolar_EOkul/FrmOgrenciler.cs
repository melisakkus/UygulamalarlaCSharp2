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

namespace İlişkiliTablolar_EOkul
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        public string Numara;
        Baglanti baglanti = new Baglanti();

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd, Sınav1, Sınav2, Proje, Ortalama, Durum from Tbl_Notlar\r\nInner Join Tbl_Dersler on Tbl_Notlar.DersId =  Tbl_Dersler.DersId where OgrId = @pId", baglanti.baglan());
            komut.Parameters.AddWithValue("@pId",Numara);
            //this.Text = Numara.ToString(); //formun sol üst köşesine
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.baglan().Close();

            SqlCommand komutAdSoyad = new SqlCommand("Select OgrenciAd, OgrenciSoyad from Tbl_Ogrenciler where OgrenciId = @pId", baglanti.baglan());
            komutAdSoyad.Parameters.AddWithValue("@pId",Numara);
            SqlDataReader reader = komutAdSoyad.ExecuteReader();
            while (reader.Read())
            {
                this.Text = reader[0].ToString() + " " +reader[1].ToString();
            }
            reader.Close();
            baglanti.baglan().Close();
        }
    }
}
