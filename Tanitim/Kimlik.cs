using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanitim
{
    internal class Kimlik
    {
        string ad;
        string soyAd;
        int yas;
        string memleket;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soyAd; }
            set { soyAd = value.ToUpper(); }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value; }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public Kimlik()
        {
            ad = "";
            soyAd = "";
            cinsiyet = 'K';
            yas = 18;
            memleket = "Ankara";
        }
    }
}
