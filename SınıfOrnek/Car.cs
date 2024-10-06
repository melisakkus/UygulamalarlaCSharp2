using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfOrnek
{
    internal class Car : CarDeatil
    {
        public string Renk;
        public int Hiz;
        public double Motor;
        public char Durum;
        public int Fiyat;
        private int Yil;
        private string Marka;

        //kapsülleme
        public int YIL
        {
            get { return Yil; }
            set { Yil = Math.Abs(value);}
        }

        public string MARKA
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }


        private string OwnerName = "Melisa Akkuş";
        public string NAME
        {
            get 
            {
                return OwnerName.Substring(0, 3) + "***" 
                    + " " + OwnerName.Substring(7, 3) + "***";
            }
            set { OwnerName = value; }
        }
    }
}
