using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_PolimorfizmUygulama
{
    class TekstilUrunu : Urun
    {
        public string KumasTipi { get; set; }
        public string Renk { get; set; }
        public string KumasKalitesi { get; set; }
        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.8m);
        }
    }
}
