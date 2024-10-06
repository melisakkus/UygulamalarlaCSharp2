using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komutListele = new SqlCommand("Select * from Tbl_Personel",Baglanti.baglanti);
            if(komutListele.Connection.State != ConnectionState.Open)
            {
                komutListele.Connection.Open();
            }

            SqlDataReader reader = komutListele.ExecuteReader();   
            while(reader.Read())
            {
                EntityPersonel entityPersonel = new EntityPersonel();
                entityPersonel.PersonelId = int.Parse(reader["PersonelId"].ToString());
                entityPersonel.PersonelAd = (reader["PersonelAd"].ToString());
                entityPersonel.PersonelSoyad = (reader["PersonelSoyad"].ToString());
                entityPersonel.PersonelSehir = (reader["PersonelSehir"].ToString());
                entityPersonel.PersonelGorev = (reader["PersonelGorev"].ToString());
                entityPersonel.PersonelMaas = short.Parse((reader["PersonelMaas"].ToString()));
                degerler.Add(entityPersonel);
            }
            reader.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel yeniPersonel)
        {  
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Personel (PersonelAd,PersonelSoyad,PersonelSehir,PersonelGorev,PersonelMaas) values (@pAd,@pSoyad,@pSehir,@pGorev,@pMaas)",Baglanti.baglanti);

            komutEkle.Parameters.AddWithValue("@pAd", yeniPersonel.PersonelAd);
            komutEkle.Parameters.AddWithValue("@pSoyad", yeniPersonel.PersonelSoyad);
            komutEkle.Parameters.AddWithValue("@pSehir", yeniPersonel.PersonelSehir);
            komutEkle.Parameters.AddWithValue("@pGorev", yeniPersonel.PersonelGorev);
            komutEkle.Parameters.AddWithValue("@pMaas", yeniPersonel.PersonelMaas);
            if (komutEkle.Connection.State != ConnectionState.Open)
            {
                komutEkle.Connection.Open();
            }
            return komutEkle.ExecuteNonQuery();
        }

        public static bool PersonelSil(int id)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Personel where PersonelId = @pId", Baglanti.baglanti);
            komutSil.Parameters.AddWithValue("@pId",id);
            if (komutSil.Connection.State != ConnectionState.Open)
            {
                komutSil.Connection.Open();
            }
            return komutSil.ExecuteNonQuery()>0;
        }

        public static bool PersonelGuncelle(EntityPersonel guncellePersonel)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personel set PersonelAd = @pAd, PersonelSoyad = @pSoyad, PersonelSehir = @pSehir, PersonelGorev = @pGorev, PersonelMaas = @pMaas where PersonelId = @pId",Baglanti.baglanti);
            komutGuncelle.Parameters.AddWithValue("@pAd",guncellePersonel.PersonelAd);
            komutGuncelle.Parameters.AddWithValue("@pSoyad",guncellePersonel.PersonelSoyad);
            komutGuncelle.Parameters.AddWithValue("@pSehir",guncellePersonel.PersonelSehir);
            komutGuncelle.Parameters.AddWithValue("@pGorev",guncellePersonel.PersonelGorev);
            komutGuncelle.Parameters.AddWithValue("@pMaas",guncellePersonel.PersonelMaas);
            komutGuncelle.Parameters.AddWithValue("@pId",guncellePersonel.PersonelId);
            if(komutGuncelle.Connection.State != ConnectionState.Open)
            {
                komutGuncelle.Connection.Open();
            }
            return komutGuncelle.ExecuteNonQuery()>0;
        }
    }
}