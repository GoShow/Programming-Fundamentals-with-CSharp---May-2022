using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string fullString = Console.ReadLine();

            while (fullString.Contains(substringToRemove))
            {
                fullString = fullString.Replace(substringToRemove, string.Empty);
            }

            Console.WriteLine(fullString);
        }
    }
}
