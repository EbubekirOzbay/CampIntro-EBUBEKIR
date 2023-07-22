using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Eklendi  : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Silindi: " + musteri.MusteriSoyadi);

        }
        public void MamaVer(Musteri musteri)
        {
            Console.WriteLine(  "Annesi:"+musteri.MusteriAdi);
        }
     



    }
}
