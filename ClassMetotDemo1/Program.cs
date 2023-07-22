using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassMetotDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); 
            musteri1.MusteriAdi="bekir";
            musteri1.MusteriSoyadi = "Özbay";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Çakıl";
            musteri2.MusteriSoyadi="Mama";

            Musteri musteri3= new Musteri();
            musteri3.MusteriAdi = "Udu";
            musteri3.MusteriSoyadi = "Ç";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MamaVer(musteri3 );


            
        }
    }
}
