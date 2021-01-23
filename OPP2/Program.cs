using System;

namespace OPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa o nesneye ait değilmiş gibi duruyorsa  ?

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Esra";
            musteri1.SoyAdi = "Bulut";
            musteri1.TcNo = "14484545";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "245454";
            musteri2.Id = 5;
            musteri2.MusteriNo = "2454541";
            musteri2.SirketAdi = "ASP.Net";
            musteri2.VergiNo = "5454545";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



            //Gerçekmüşyeri tüzelmüşteriyide tutabiliyor
            //Bir yerde neew görürseniz bu bellekteki bir referans nosu. Müsteri classı hem gerçek hemde tüzel müşterinin referansını tutabiliyot.
            //oyüzdendir ki müşteri menagerde müşteri diye parametre gönderdik ya ben oraya aslında 

            //Gerçe- Tüzel
            //Bunlar sırf birbirine benziyor diye birbirinin yerine kullanamazlar. 
            //ikiside müşteri ama bunlar farklı müşteri tipler.Birbirlerinin yerine kullanamazlar.
        }
    }
}
