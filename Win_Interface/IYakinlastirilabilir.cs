using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Interface
{
    public interface IYakinlastirilabilir
    {
        /*
         * Interface
         * -interface içinde özellik, metot indeksleyici ve olay(event) haricinde bir şey bulunmaz.
         * 
         * interface içindeki elemanların abstract sınıflarda olduğu gibi gövdesi bulunmaz.
         * 
         * abstract sınıftan 1. farkı:  gövdesi olan bir metot veya özellik yazamayız.
         * 
         * Abstract sınıftan 2. farkı: interface içindeki elemanların access modifiers'leri bulunmaz ve
         * varsayılan access modifiers'leri public'dir.
         * 
         * Interface sınıflardan nesne üretilemez.
         */

        string Yakinlastir();
    }
}
