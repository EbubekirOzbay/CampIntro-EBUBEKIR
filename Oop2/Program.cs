using System;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GercekMusteri musteri1= new GercekMusteri();
            musteri1.Id = 1;    
            musteri1.MüsteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2= new TuzelMusteri();  
            musteri2.Id = 2;
            musteri2.MüsteriNo="54321";
            musteri2.SirketAdi = "Kodlamaio";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}