using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Generic
{
    class Ogrenci<T,H,Y> where T:class
    {
        /*
         * Dışarıdan bir tip alarak çalışmayı saplayan bir yapıdır.
         */
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Y OkulNo { get; set; }
        public H Okulu { get; set; }

        public T TemsiliTip { get; set; }

        public void Ekle(T prm)
        {

        }
    }
}
