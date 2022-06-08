using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(@base, power));
        }

        static double MathPower(double @base, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }

            return result;
        }
    }
}
