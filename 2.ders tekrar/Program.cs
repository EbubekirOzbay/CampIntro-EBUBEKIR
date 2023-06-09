using System;

namespace _2.ders_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
            //type safety tip güvenliği
            //do not repeat your self kendini tekrarlama
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.32;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("degismedi");
            }

            if (sistemeGirisYapmismi==true) 
            {
                Console.WriteLine("kullanıcı ayaları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");

            }

           
        }
    }
}
