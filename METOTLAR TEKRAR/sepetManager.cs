using System;
using System.Collections.Generic;
using System.Text;

namespace METOTLAR_TEKRAR
{
    internal class sepetManager

    {
        public void Ekle(Urun urun)
            //naming convention  isimlendirme kuralı
            // normal() olduğu yerde bir metot çalışır
            // syntax yazım şekilleri
            //encapsulation - kapsüllemedir düzene sokmak
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :" + urun.Adi);

        }
        public void Ekle2( string UrunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi:" + UrunAdi);

        }
    }
}
