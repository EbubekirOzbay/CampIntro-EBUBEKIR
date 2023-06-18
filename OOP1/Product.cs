using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class Product
    //sineppet
    //Product - ürün demek //ProductName ürün ADI
    //Unitprice -ürün birim FİYATI demek
    // ID 1.sıraya yazılır //CatagroyId ürün referansı 2.sıraya yazılır
    //CatagroyId hangi katagoriye ait olduğu
    //UnItsInStock STOK ADEDİ
    //NOT Managerin olduğu alanda operasyon olur ekleme silme güncelleme vs
    //ADD EKLE DEMEK
    //PascalCase kelimelerin ilk harfi büyük yazılır
    //camelCase kelimelerin ilk harfi küçük sonraki harf büyük
    //case sensitive -küçük büyük hafr duyarlı //ProductManager bir class productManager clasın değişkenidir.
    

    {
        public int Id { get; set; }
        public int CatagroyId { get; set; }
        public string  ProductName { get; set; }
        public double Unitprice { get; set; }
        public int UnItsInStock { get; set; }


    }
}
