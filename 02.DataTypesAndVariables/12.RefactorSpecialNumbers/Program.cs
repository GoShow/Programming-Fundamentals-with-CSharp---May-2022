using System;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            for (int number = 1; number <= counter; number++)
            {
                int sum = 0;
                int digits = number;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }

                bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{number} -> {isSpecialNumber}");
            }
        }
    }
}
