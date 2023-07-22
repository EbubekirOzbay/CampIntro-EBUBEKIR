using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Bekir";
            musteri1.MusteriSoyadi = "Özbay";
            musteri1.TcNo = 123456;

            Musteri musteri2= new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Udu";
            musteri2.MusteriSoyadi = "Çakıl";
            musteri2.TcNo = 3;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);


        }
    }
}
