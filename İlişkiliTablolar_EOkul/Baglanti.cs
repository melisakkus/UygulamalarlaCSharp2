using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlişkiliTablolar_EOkul
{
    internal class Baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
