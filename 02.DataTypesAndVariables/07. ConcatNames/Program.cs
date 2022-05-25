using System;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string concatNames = $"{firstName}{delimiter}{lastName}";

            Console.WriteLine(concatNames);
        }
    }
}
