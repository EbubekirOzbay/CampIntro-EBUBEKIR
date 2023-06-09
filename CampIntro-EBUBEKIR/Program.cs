using System;
using System.ComponentModel.Design;
using System.Numerics;

namespace CampIntro_EBUBEKIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenli (string, int, float gibi değerleri tanımlarken değişkenin başında bu tipler kullanılır.)
            //do not repeat your self = kendini tekrar etme
            // double ondalıklı sayi,integer tam sayılar
            //değer tutucu alias

            string baslik = "hello world";
            Console.WriteLine(baslik);
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            double FaizOrani = 1.45;
            bool sistemeGirisYapmismi = true;


            if (sistemeGirisYapmismi == false)
            {
                Console.WriteLine("kullanıcı Ayarları");
            }
            else 
            { 
                Console.WriteLine("giriş Yap Butonu"); 
            }
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artis Butonu");
  
            }
            else 
            {
                Console.WriteLine("degismedi");
            }

         

        }
    }
}
