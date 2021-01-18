using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Static
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanimliOgrenciSayisi++;
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
        public static int TanimliOgrenciSayisi { get; set; }
        /*
         * Sınıftan bir örnek oluşturmadan sonuna nokta koyarak statik elemana ulaşmamızı sağlar.
         */

        public static void Ekle() 
        {
            /*veritabanına öğrenci eklemeye yarayan metot*/
            //Statik metotlar içerisinden statik olayan elemanlara ulaşılamaz.
            //Statik metotlar içinde sadece statik elemanlara ulaşılabilir.

            int TanimliOgrenciSayisi;
        }

    }
}
