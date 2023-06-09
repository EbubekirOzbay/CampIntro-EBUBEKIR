using System;

namespace METOTLAR_TEKRAR
{
    internal class Program
    {
        static void Main(string[] args)
            //Array dizi demek []
            //instance -class örneği oluşturma

        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 35;
            urun3.Aciklama = "Sivas";



            Urun[] urunler = new Urun[] { urun1,urun2,urun3};
            foreach (var urun in urunler)
            
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine( urun.Fiyati);
                Console.WriteLine( urun.Aciklama);
                Console.WriteLine( "---------");
                


            }
            Console.WriteLine(  "----Metotlar---");
            
            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut","Yeşil armut",12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);


            


        }
          
    }
}
