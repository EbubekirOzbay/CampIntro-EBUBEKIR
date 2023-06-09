using System;

namespace classExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Product[] products = new Product[] {};


            foreach (Product urun in products)
            {
                //Console.WriteLine(urun.Name);
                //Console.WriteLine(urun.Price);
            }
            Product kadınurun = new Product();

            kadınurun.Name = "yudum";
            kadınurun.Price = 15.1f;
            kadınurun.Aciklama = "test";


            Console.WriteLine(kadınurun.Name+ "  "+kadınurun.Aciklama);






        }
    }

    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Aciklama { get; set; }

    }
}
