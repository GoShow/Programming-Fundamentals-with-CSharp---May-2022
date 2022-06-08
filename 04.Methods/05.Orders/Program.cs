using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintTotalPrice(order, quantity);
        }

        static void PrintTotalPrice(string order, int quantity)
        {
            decimal coffee = 1.5m;
            decimal water = 1m;
            decimal coke = 1.4m;
            decimal snacks = 2m;

            switch (order)
            {
                case "coffee":
                    Console.WriteLine($"{(coffee * quantity):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{(water * quantity):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(coke * quantity):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(snacks * quantity):f2}");
                    break;
            }
        }
    }
}
