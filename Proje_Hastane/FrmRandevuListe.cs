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
    public partial class FrmRandevuListe : Form
    {
        public FrmRandevuListe()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();
        private void FrmRandevuListe_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Randevular", baglan.Baglanti());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglan.Baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    } 
}