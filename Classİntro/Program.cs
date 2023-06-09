using System;

namespace Classİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = ("bekir");
            int yas = 30;

            kurs kurs1=new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Bekir";
            kurs1.IzlenmeOrani = "68";

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "engin";
            kurs2.IzlenmeOrani = "33";

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Payton";
            kurs3.Eğitmen = "Kerem";
            kurs3.IzlenmeOrani = "90";


            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }



            // Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Eğitmen);






            Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public string IzlenmeOrani{ get; set; }

    }
}
