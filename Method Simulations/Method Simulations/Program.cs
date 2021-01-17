using System;

namespace Method_Simulations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dont repeat yourself

            Product product1 = new Product();

            product1.Name = "Television";
            product1.Price =2000;
            product1.Comment = "Hd Television";

            Product product2 = new Product();

            product2.Name = "Book";
            product2.Price = 250;
            product2.Comment = "Local Book";

            Product[] products = new Product[] { product1, product2 };

            Console.WriteLine("List of Products");
            //type safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);

                Console.WriteLine(product.Price);
                Console.WriteLine(product.Comment);

                Console.WriteLine("-------------------");

            }


            BasketManager basketmanager = new BasketManager();
            basketmanager.Add(product1);
            basketmanager.Add(product2);

            Console.WriteLine("-------------------");
            basketmanager.Delete(product1);
            basketmanager.Delete(product2);

            Console.WriteLine("-------------------");
            basketmanager.Update(product1);
            basketmanager.Update(product2);

            Console.WriteLine("-------------------");
            //Type2
            basketmanager.Add2("Mouse","wifi mouse",500);

        }
    }
}
