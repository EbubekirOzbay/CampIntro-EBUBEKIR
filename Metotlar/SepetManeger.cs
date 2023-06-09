using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManeger
    {

        //naming convention isimlendirme kuralı
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {

            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }


    }
    class Kullanici
    {
        public string Adi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
