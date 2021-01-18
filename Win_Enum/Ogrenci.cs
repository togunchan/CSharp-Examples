using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Enum
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Alan Alani { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }

    /*
     * 
     * String şeklinde enumların içine değer yazılmaz.
     * Enum içindeki seçenej bir kelimeden fazla olsa bile 
     * kelemeler arasında boşluk bırakılmaz.
     * 
     * Not: Enum'lar kullanıcının seçeceği seçenekler için oluşturulan bir yapı değildir.
     * 
     * Programcının uygulamasını idame ettirmesi için kullandığı bir yapıdır.
     * 
     * Enum sınıfı içinde getName ve getNames adlı 2 tane metot vardır.
     * 
     * GetName: Verilen enum seçeneğinin değerini döndürür.
     * Enum.GetName(typeof(Alan),o2.Alani);
     * 
     * GetNames: Geriye string dizisi döndürür. Geriye belirtilen enum tipinin içindeki tüm seçenekleri
     * string olarak döndürür.
     * 
     * Enum.GetNames(typeof(Alan));
     * 
     */
    public enum Alan
    {
        Sayisal=10,
        Sozel=20,
        EsitAgirlik=30,
        Dil=40
    }
}
