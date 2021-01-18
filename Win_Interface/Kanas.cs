using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Interface
{
    class Kanas : AtesliSilahlar, IYakinlastirilabilir
    {
        public string Yakinlastir()
        {
            return "Yakınlaştırıldı.";
        }
    }
}
