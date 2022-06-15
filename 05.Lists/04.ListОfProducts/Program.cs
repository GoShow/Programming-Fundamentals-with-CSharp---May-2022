using System;
using System.Collections.Generic;

namespace _04.ListОfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            int counter = 1;

            foreach (var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
