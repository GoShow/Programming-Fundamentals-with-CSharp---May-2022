using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
                switch (action)
                {
                    case "swap":
                        Swap(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "multiply":
                        Multiply(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "decrease":
                        Decrease(numbers);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Swap(int firstIndex, int secondIndex, List<int> numbers)
        {
            int temp = numbers[firstIndex]; ;
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }

        static void Multiply(int firstIndex, int secondIndex, List<int> numbers)
        {
            numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
        }

        static void Decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            };
        }
    }
}
