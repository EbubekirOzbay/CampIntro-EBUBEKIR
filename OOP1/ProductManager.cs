using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
             
        {
            Console.WriteLine( product.ProductName + "Eklendi");
        }

        public void Id (Product product)
        {
            Console.WriteLine(  product.Id+"düzen");
        }
       
        
      
    }    
}
