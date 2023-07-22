using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    internal class TuzelMusteri:Musteri
        //Kalıtım bırakma ortak özellikleri barındıran nesnelere ortak bir nesne oluşturularak ortak olanlara verilmesi.
        //Örnek :nokta ile yanına bir class oluşturulur.
        //coorparate TuzelMusteri
        //Miras inheritance 
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
