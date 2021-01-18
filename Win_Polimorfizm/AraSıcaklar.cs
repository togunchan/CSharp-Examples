using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Polimorfizm
{
    class AraSıcaklar : Yemek
    {
        public override string SunumSekli()
        {
            return "Yanında patates kızartması ve içecek ile";
        }

        /*
         * override metodu ezmek anlamına gelir. Çalışma yapısını değiştirmemizi sağlar.
         */
    }
}
