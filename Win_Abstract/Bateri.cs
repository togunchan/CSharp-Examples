using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Abstract
{
    class Bateri : MuzikAletleri
    {
        public override CalmaTuru CalmaTuru
        {
            get => CalmaTuru.VurmaliCalma;
            set => throw new NotImplementedException();
        }

        public override string Cal()
        {
            throw new NotImplementedException();
        }
    }
}
