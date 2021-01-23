using System;
using System.Collections.Generic;
using System.Text;

namespace OPP2
{                        //Miras- İnheritance diyoruz 
    class TuzelMusteri: Musteri                 //Tüzel müşteri debir müşteridir.(Miras)
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
