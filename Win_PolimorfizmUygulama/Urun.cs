using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_PolimorfizmUygulama
{
    class Urun
    {
        public string Adi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public virtual decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.18m);
        }
    }
}
