using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOddNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= countOfOddNumbers; i++)
            {

                int currentOddNumber = 1 + (i * 2);

                // i == 0; currentOddNumber = 1 + (0 * 2) = 1
                // i == 1; currentOddNumber = 1 + (1 * 2) = 3
                // i == 2; currentOddNumber = 1 + (2 * 2) = 5

                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
