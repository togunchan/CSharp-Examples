using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_InterfaceUygulama
{
    class Muslera : Futbolcu, ITopTutabilir
    {
        public string TopTut()
        {
            return "Top tutuldu";
        
        }
    }
}
