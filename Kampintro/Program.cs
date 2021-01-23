using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KatagoriEtiketi = "Katagoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapildiMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }

            else
            {
                Console.Write("Seğişmedi Bugot");
                
            }

            if (sistemeGirisYapildiMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine(KatagoriEtiketi);
            }
        }
    }
}
