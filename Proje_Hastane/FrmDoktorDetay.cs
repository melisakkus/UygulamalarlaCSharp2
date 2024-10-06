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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        
        SqlBaglantisi baglan = new SqlBaglantisi();
        public string doktorTc;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = doktorTc;

            SqlCommand komutAdSoyad = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc = @pTc",baglan.Baglanti());
            komutAdSoyad.Parameters.AddWithValue("@pTc",lblTcNo.Text);
            SqlDataReader reader = komutAdSoyad.ExecuteReader();
            while (reader.Read())
            {
                lblAd.Text = reader[0].ToString();
                lblSoyad.Text = reader[1].ToString();
            }
            baglan.Baglanti().Close();

            DataTable dataTable = new DataTable();
            string adSoyad = lblAd.Text +" "+lblSoyad.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor ='"+adSoyad+"'",baglan.Baglanti());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sayi = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[sayi].Cells[7].Value.ToString();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular(); 
            frmDuyurular.Show();
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle doktorBilgiDüzenle = new FrmDoktorBilgiDüzenle();
            doktorBilgiDüzenle.Tc = doktorTc;
            doktorBilgiDüzenle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

