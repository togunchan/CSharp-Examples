using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Interface
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDegeri { get; set; }
        public Silah Silahi { get; set; } 
        public string NisanAl()
        {
            //nişin alma işlemleri yapılacak
            //silahi özelliği interface özelliğine sahipse
            if (Silahi is IYakinlastirilabilir)
            {
                IYakinlastirilabilir iy = (IYakinlastirilabilir)Silahi;
                return iy.Yakinlastir();
            }
            else
            {
                return "";
            }
        }

        public void Saldir()
        {
            //saldırma işlemleri yapılacak.
        }
    }
}
