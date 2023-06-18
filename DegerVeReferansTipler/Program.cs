using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        // int , decimal ,float , double, bool =DEĞER TİP
        // Array , class , interface= REFERANS TİP

        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");

            string[] kalem1 = new string[] {"beyaz" , "Siyah"};
            string[] kalem2 = new string[] { "kırmızı", "mavi" };
            kalem1 = kalem2;
            kalem2[0] = "sarı";
            Console.WriteLine(kalem1);


        }
        
    }
}
