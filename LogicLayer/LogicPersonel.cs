using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LogicLayerPersonelListesi()
        {
            return DataAccessLayer.DALPersonel.PersonelListesi();
        }

        public static int LogicLayerPersonelEkleme(EntityPersonel yeniPersonel)
        {
            if(yeniPersonel.PersonelAd != "" && yeniPersonel.PersonelSoyad !="" && yeniPersonel.PersonelGorev != "")
            {
                return DataAccessLayer.DALPersonel.PersonelEkle(yeniPersonel);
            }
            else
            {
                return -1;
            }
        }

        public static bool LogicLayerPersonelSilme(int id)
        {
            if (id > 0)
            {
                return DALPersonel.PersonelSil(id);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerPersonelGuncelle(EntityPersonel guncellePersonel)
        {
            if(guncellePersonel.PersonelAd.Length >= 2 && guncellePersonel.PersonelSoyad.Length >= 2 &&  guncellePersonel.PersonelMaas >= 18000 )
            {
                return DataAccessLayer.DALPersonel.PersonelGuncelle(guncellePersonel);
            }
            else
            {
                return false;
            }
        }
    }
}
