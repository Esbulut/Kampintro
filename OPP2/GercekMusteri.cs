using System;
using System.Collections.Generic;
using System.Text;

namespace OPP2
{
    class GercekMusteri:Musteri                  //Gerçek müşteri de bir müşteridir.(Miras.)
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}
