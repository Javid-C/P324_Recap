
using System;

namespace P324_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Bu bir custom contains methodudur";

            //Console.WriteLine(text.customContains("methodudur"));

            Product product = new Product();
            product.Name = "Tea";
            product.Price = 20.5d;
            product.Count = 30;
            Console.WriteLine(product.TotalInCome);
            Console.WriteLine(product.Sell());
            Console.WriteLine(product.Sell());
            Console.WriteLine(product.TotalInCome);
        }
    }
}
