using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");

                    break;
                }
                else
                {
                    sum += firstArray[index];
                }

                if (index == firstArray.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }
        }
    }
}
