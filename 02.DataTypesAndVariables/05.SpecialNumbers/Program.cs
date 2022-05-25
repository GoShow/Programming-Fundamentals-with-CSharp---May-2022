using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                int sum = 0;
                int currentNum = i;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;

                    //124 - special number with sum == 7
                    //124 % 10 = 4
                    //124 / 10 = 12
                    //sum = 4

                    //12 % 10 = 2
                    //12 / 10  = 1
                    //sum = 4 + 2

                    // 1 % 10 = 1
                    // 1 / 10 = 0
                    //sum = 4 + 2 + 1

                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }

    }
}
