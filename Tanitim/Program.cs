using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tanitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liste liste = new Liste();
            //string adSoyad;
            //Console.WriteLine("Ad Soyad : ");
            //adSoyad = Console.ReadLine();
            //liste.KisiListesi(adSoyad);
            //Console.Read();

            //KisiselBilgiler kisiselBilgiler = new KisiselBilgiler();
            //kisiselBilgiler.BilgiAl("Melisa","Akkuş",22,"Mühendis");
            //Console.Read();

            //string aciklama;
            //Console.Write("Ad - Kulüp: ");
            //aciklama = Console.ReadLine(); 
            //Ogrenci ogrenci = new Ogrenci(aciklama);
            //Console.Read();

            //Console.WriteLine("Ad giriniz: ");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyad giriniz: ");
            //string soyad = Console.ReadLine(); 

            //Console.WriteLine("Yas giriniz: ");
            //int yas = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Meslek giriniz: ");
            //string meslek = Console.ReadLine();

            //BilgiAl bilgiler = new BilgiAl(ad,soyad,yas,meslek);
            //Console.Read();

            Kimlik kimlik = new Kimlik();
            kimlik.AD = "sena";
            Console.WriteLine("AD: " + kimlik.AD);            
            kimlik.SOYAD = "akkuş";
            Console.WriteLine("SOYAD: " + kimlik.SOYAD);
            Console.WriteLine("CINSIYET: " + kimlik.CINSIYET);
            Console.WriteLine("MEMLEKET: " + kimlik.MEMLEKET);
            Console.WriteLine("YAS: " + kimlik.YAS);
            Console.Read();

        }
    }
}
