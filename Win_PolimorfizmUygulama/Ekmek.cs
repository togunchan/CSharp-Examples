using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_PolimorfizmUygulama
{
    class Ekmek : Urun
    {
        public double Gramaj { get; set; }
        public string EkmekTipi { get; set; }

        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.1m);
        }
    }
}
