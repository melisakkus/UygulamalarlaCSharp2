using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlBaglantisi baglantisi = new SqlBaglantisi();
            baglantisi.AdresiYazdır();
            Console.ReadLine();
        }
    }


    internal class SqlBaglantisi
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\Users\90505\Desktop\Adres.txt");
        SqlConnection connection = new SqlConnection(Adres);

    }

}

