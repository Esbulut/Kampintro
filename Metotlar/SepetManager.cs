using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlaar
{
    class SepetManager
    {
        //naming convention
        //syntax-yazım değişimleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!:"+urun.UrunAdi+" "+urun.Fiyati+urun.StokAdedi);
        }
        public void Ekle2(string UrunAdi, string Aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!");
        }

    }
}
