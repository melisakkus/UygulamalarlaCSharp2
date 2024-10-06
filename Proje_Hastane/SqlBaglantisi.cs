using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            string connectionString = System.IO.File.ReadAllText(@"C:\Users\90505\Desktop\Adres.txt").Trim();
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            return baglanti;
        }
    }
}
