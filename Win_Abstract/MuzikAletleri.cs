using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Abstract
{
    abstract class MuzikAletleri
    {
        /*
         * Abstract(soyut) sınıflar sadece miras verilmek için tasarlanan sınıflardır.
         * Abstractlar sınıfa özel değil herhangi bir eleman absctact olabilir.
         * 
         * Bir metotun abstract olması o metot miras verilen metotlarda ezilmek zorundadır.
         * 
         * Abstract metotların gövdesi olmaz.
         * 
         * Abstract metotlar öyle olmayan sınıflarda bulunamaz.
         * 
         * Abstract olmayan özellik veya metot olabilir.
         * 
         * 
         */

        public abstract string Cal();
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTuru CalmaTuru { get; set; }


    }
}
