using System;
using task._12.Robots;

namespace task._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
                       
            Product[] product = { 
                new Product(1, 55),
                new Product(12, 55),               
                new Product(2, 3), 
                new Product(3, 3), 
                new Product(4, 85) };

            for (int i = 0;i<product.Length; i++)
            {
                manager.analyzer.Sorting(product[i]);
            }

            manager.HeavyQueueClear();
            manager.LigtQueueClear();

            foreach (var roduct in manager.storage.Products)
            {
                Console.WriteLine(roduct.Key + " " + roduct.Value);
            }

            Console.WriteLine("---------------");
            manager.GetFromStorage(1);
            manager.GetFromStorage(12);
            manager.GetFromStorage(2);


            foreach (var roduct in manager.storage.Products)
            {
                Console.WriteLine(roduct.Key + " " + roduct.Value);
            }
            
        }
    }
}
