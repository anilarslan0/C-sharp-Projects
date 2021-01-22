using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(01, "Adana");
            cities.Add(61, "Trabzon");
            cities.Add(34, "İstanbul");
            cities.Add(54, "Sakarya");
            cities.Add(82, "Paris");

            for (int i = 0; i < cities.Keys.Length; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1} ", cities.Keys[i], cities.Values[i]);
            }
        }
    }
}
