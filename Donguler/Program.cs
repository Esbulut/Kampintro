﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] kurslar = new string[] {"Yazılım Geliştirici Yerleştirme Kampı" , "Programlamaya başlangıç için temel kurs" ,"Java","Python"};    

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
     
    }
}
