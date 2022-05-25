using System;

namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double poundsToUsdRate = 1.31;

            double result = pounds * poundsToUsdRate;

            Console.WriteLine($"{result:f3}");
        }
    }
}
