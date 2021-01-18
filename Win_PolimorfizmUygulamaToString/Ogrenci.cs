using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_PolimorfizmUygulamaToString
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tckn { get; set; }
        public DateTime DogumTarihi { get; set; }

        //public override string ToString()
        //{
        //    return string.Format("{0}-{1}-{2}-{3}", Adi, Soyadi, Tckn, DogumTarihi);
        //}
    }
}
