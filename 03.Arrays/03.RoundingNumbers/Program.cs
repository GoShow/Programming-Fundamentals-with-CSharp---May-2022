using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
