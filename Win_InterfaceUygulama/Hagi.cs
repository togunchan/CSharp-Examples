using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_InterfaceUygulama
{
    class Hagi : Futbolcu, IOyunKurabilir, ISutCekebilir
    {

        public string CalimAt(float hiz)
        {
            return string.Format("{0} hızla çalım atıldı", hiz);
        }

        public string OyunKur()
        {
            return "oyun kuruldu";
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeye kadar şut çekildi", hiz, mesafe);
        }
    }
}
