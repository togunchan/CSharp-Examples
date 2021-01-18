using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_InterfaceUygulama
{
    class ServetCetin : Futbolcu, ISavunabilir
    {
        public string SavunmaYap()
        {
            return "savunma yapıldı";
        }
    }
}
