using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_IEnumerator
{
    class Takim
    {
        public Takim()
        {
            Oyuncular = new List<Oyuncu>();
        }

        public string Adi { get; set; }
        public DateTime KurulusYili { get; set; }
        public string StadIsmi { get; set; }
        public List<Oyuncu> Oyuncular { get; set; }
    }
}
