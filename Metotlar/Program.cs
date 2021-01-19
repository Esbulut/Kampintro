using System;

namespace Metotlaar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya  Elması";
            urun1.StokAdedi = 90;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 55;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 45;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Armut";
            urun3.Fiyati = 12;
            urun3.Aciklama = "Taze Armut";
            urun3.StokAdedi = 66;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Nar";
            urun4.Fiyati = 13;
            urun4.Aciklama = "Kırmızı Nar";
            urun4.StokAdedi = 75;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("-----------------------Metotlar-----------------------------");

            //İnstance-örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 5);



        }
    }
}

