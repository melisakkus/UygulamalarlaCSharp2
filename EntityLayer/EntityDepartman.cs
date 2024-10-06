using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartman
    {
        private int departmanId;
        private string departmanAd;
        private string departmanAciklama;

        public int DepartmanId { get => departmanId; set => departmanId = value; }
        public string DepartmanAd { get => departmanAd; set => departmanAd = value; }
        public string DepartmanAciklama { get => departmanAciklama; set => departmanAciklama = value; }
    }
}
