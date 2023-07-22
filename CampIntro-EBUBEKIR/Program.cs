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

            Alici ebuabi = new Alici();
            ebuabi.TeslimatAdresi = "ankara";
            ebuabi.Name = "Ebu";

            Satici yasin = new Satici();
            
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Name = "Yudum";
            tedarikci.TedarikAracıMarkası = "Mercedes";

            User kullanici1 = new User();
            kullanici1.Name = "ebu Müdür"; //Set
            kullanici1.Age = 29;


            User kulllanici2 = new User();
            kulllanici2.Name = "Yasin Üye"; //Set
            kulllanici2.Age = 29;



            //Ui 
            Console.WriteLine(kullanici1.Name); // Get
            Console.WriteLine(kulllanici2.Name); //Get
        }
    }



    public class Alici:User
    {
        
        public string TeslimatAdresi { get; set; }

    }
    public class Satici:User
    {
       
        public int VergiNo { get; set; }
        public string ÜrününAdı { get; set; }
    }
    public class Tedarikci:User
    {
        public string TedarikAracıMarkası { get; set; }
        public int KacStokGetirecek { get; set; }
    }
    public class User
    {
        //get; veriyi okuma izni verir
        //set; veriyi yazma izni verir
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Boy { get; set; }
    }
}
