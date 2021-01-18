using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_InterfaceUygulama
{
    class Fernandao : Futbolcu, ISutCekebilir
    {
        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeye kadar şut çekildi", hiz, mesafe);
        }
    }
}
