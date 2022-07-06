using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> countsByNumber = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!countsByNumber.ContainsKey(number))
                {
                    countsByNumber.Add(number, 0);
                }

                countsByNumber[number]++;
            }

            foreach (var countByNumber in countsByNumber)
            {
                Console.WriteLine($"{countByNumber.Key} -> {countByNumber.Value}");
            }
        }
    }
}
