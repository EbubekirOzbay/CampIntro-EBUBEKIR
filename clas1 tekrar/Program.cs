using System;

namespace clas1_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.IzlenmeOrani = 68;


            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 80;



            //Console.WriteLine(kurs1.KursAdi+ " : "+ kurs1.Egitmen);

            kurs [] kurslar =new kurs[] { kurs1, kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : "+ kurs.Egitmen);


            }

            

        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}


