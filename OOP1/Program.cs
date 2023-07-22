using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagroyId = 2;
            product1.ProductName = "Masa";
            product1.Unitprice = 500;
            product1.UnItsInStock = 3;
             
            Product product2 = new Product {Id=2,CatagroyId=5,UnItsInStock=5,ProductName ="kalem",Unitprice=35 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            

        }
    }
}
