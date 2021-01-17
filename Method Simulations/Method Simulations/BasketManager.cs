using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Simulations
{
     public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to Basket");
        }

        public void Add2(string productName,string comment,double prince)
        {
            Console.WriteLine("Added to Basket");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Updated Basket");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Deleted from Basket");
        }


    }
}
