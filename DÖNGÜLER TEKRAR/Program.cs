using System;

namespace DÖNGÜLER_TEKRAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array dizi []
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç İçin Temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c++";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlama Başlangıç İçin Temel kurs", "java", "python", "C++" };

            for (int i =0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

                Console.WriteLine("for bitti");
            }
            Console.WriteLine("sayfa sonu-footer");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

           

           
        }
    }
}
