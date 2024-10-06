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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        void Temizle()
        {
            tbxId.Text = "";
            tbxAd.Text = "";
            tbxSoyAd.Text = "";
            cbxSehir.Text = "";
            maskedtbxMaas.Text = "";
            tbxMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            tbxId.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnListele_Click(object sender, EventArgs e) //Listele butonunu kaldırdım!
        {
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        void Listeleme()
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyAd,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",tbxAd.Text);
            komut.Parameters.AddWithValue("@p2",tbxSoyAd.Text);
            komut.Parameters.AddWithValue("@p3",cbxSehir.Text);
            komut.Parameters.AddWithValue("@p4",maskedtbxMaas.Text);
            komut.Parameters.AddWithValue("@p5", tbxMeslek.Text);
            komut.Parameters.AddWithValue("@p6",label5.Text);
            komut.ExecuteNonQuery();
            Listeleme();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label5.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label5.Text = "False";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Personel where PerId = @k1",baglanti);
            komutSil.Parameters.AddWithValue("@k1",tbxId.Text);
            komutSil.ExecuteNonQuery();
            Listeleme();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Silindi");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxSoyAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbxSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedtbxMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if(label5.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label5.Text == "False")
            {
                radioButton2.Checked = true;    
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Personel Set PerAd = @pAd , PerSoyAd = @pSoyAd, PerSehir =@pSehir, " +
                "PerMaas = @pMaas , PerDurum = @pDurum , PerMeslek = @pMeslek where PerId = @pId",baglanti);
            komutGüncelle.Parameters.AddWithValue("@pAd", tbxAd.Text);
            komutGüncelle.Parameters.AddWithValue("@pSoyAd", tbxSoyAd.Text);
            komutGüncelle.Parameters.AddWithValue("@pSehir",cbxSehir.Text);
            komutGüncelle.Parameters.AddWithValue("@pMaas",maskedtbxMaas.Text);
            komutGüncelle.Parameters.AddWithValue("@pDurum",label5.Text);
            komutGüncelle.Parameters.AddWithValue("@pMeslek",tbxMeslek.Text);
            komutGüncelle.Parameters.AddWithValue("@pId",tbxId.Text);
            komutGüncelle.ExecuteNonQuery();
            Listeleme();
            baglanti.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafik grafik = new FrmGrafik();
            grafik.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmRaporlar raporForm = new FrmRaporlar();
            raporForm.Show();             
        }
    }
}
