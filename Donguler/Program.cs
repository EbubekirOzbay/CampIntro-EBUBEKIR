using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Donguler
{
 
    internal class Program
    {



    
        private static bool dolar;

        static void Main(string[] args)
        {

            //array _dizi []
            //foreach dizileri tek tek dolaşmaya yarar.
            //değer tutucu alias
            //bool  değer tutucu demek
            //ilk noktalı virgüle kadar olan kısım değerin başlangıcıdır.
            //ikinci noktalı virgüle kadar olan kısım koşulumuzdur.
            //başlangıç değeri her dönmede ne kadar artıracağını belirler

            String[] kurslar = new string[] { "Yazılım Geliştirici Temel Kurs", "Programlamaya Başlangıç İçin Temel Kurs", "java", "python" };

            {
                Console.WriteLine(kurslar);
            }
            bool sistemeGirisYapmismi = true;

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) ;
            {
                Console.WriteLine("Azalış Butonu");
            }
            string kurs1 = "Yazılım Geliştime";
            string kurs2 = "Programlama";
            string kurs3 = "java";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            string[] kitap = new string[] { "kalem1", "kitap2", "kağıt3" };
            for (int i = 0; i < kitap.Length; i++)
            {
                Console.WriteLine(kitap[i]);
            }
            foreach (string kit in kitap)
            {
                Console.WriteLine(kitap);
            }






        }
    }
}

































































