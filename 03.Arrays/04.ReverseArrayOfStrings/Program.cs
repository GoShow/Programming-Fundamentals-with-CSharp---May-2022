using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(elements);

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
