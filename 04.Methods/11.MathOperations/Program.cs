using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));
        }
        static double Calculate(double first, string @operator, double second)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = first + second; break;
                case "-":
                    result = first - second; break;
                case "*":
                    result = first * second; break;
                case "/":
                    result = first / second; break;
            }

            return result;
        }
    }
}
