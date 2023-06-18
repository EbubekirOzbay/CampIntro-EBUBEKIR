using System;

namespace _3_._DERS_TEKRAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double UrunFiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1 .Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama= "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu"
;
            Urun[] urunler = new Urun[] { urun1,urun2};






          


            Console.WriteLine("Hello World!");
        }
    }
}
