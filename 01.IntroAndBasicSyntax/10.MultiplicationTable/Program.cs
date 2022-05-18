using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{integer} X {times} = {integer * times}");
            }
        }
    }
}
