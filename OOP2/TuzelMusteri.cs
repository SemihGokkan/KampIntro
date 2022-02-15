using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri:Musteri   //:Musteri olayına miras  / inheritance TuzelMusteri bir müşteridir demek.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
