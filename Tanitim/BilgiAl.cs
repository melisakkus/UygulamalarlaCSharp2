using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanitim
{
    internal class BilgiAl
    {
        public BilgiAl(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Kullanıcı Bilgileri : ");
            Console.WriteLine("Ad : " + ad); 
            Console.WriteLine("Soyad : " + soyad);
            Console.WriteLine("Yas : " + yas);
            Console.WriteLine("Meslek : " + meslek);
        }
    }
}
