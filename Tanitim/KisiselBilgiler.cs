using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanitim
{
    internal class KisiselBilgiler
    {
        public void BilgiAl(string ad, string soyAd, int yas, string meslek)
        {
            Console.WriteLine("Ad : " + ad);
            Console.WriteLine("Soyad : " + soyAd);
            Console.WriteLine("Yaş : " + yas);
            Console.WriteLine("Meslek : " + meslek);
        }
    }
}
