using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> gaussNumbers = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentGaussNumber = numbers[i] + numbers[numbers.Count - 1 - i];
                gaussNumbers.Add(currentGaussNumber);
            }

            if (numbers.Count % 2 != 0)
            {
                gaussNumbers.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", gaussNumbers));
        }
    }
}
