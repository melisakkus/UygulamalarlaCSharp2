using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int personelId;
        private string personelAd;
        private string personelSoyad;
        private string personelSehir;
        private string personelGorev;
        private short personelMaas; //sql : tinyint c# : short

        public int PersonelId { get => personelId; set => personelId = value; }
        public string PersonelAd { get => personelAd; set => personelAd = value; }
        public string PersonelSoyad { get => personelSoyad; set => personelSoyad = value; }
        public string PersonelSehir { get => personelSehir; set => personelSehir = value; }
        public string PersonelGorev { get => personelGorev; set => personelGorev = value; }
        public short PersonelMaas { get => personelMaas; set => personelMaas = value; }
    }
}
