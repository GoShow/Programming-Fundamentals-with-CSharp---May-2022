using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            int turn = 1;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                int[] indices = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = indices[0];
                int secondIndex = indices[1];

                if (firstIndex == secondIndex
                    || firstIndex < 0
                    || firstIndex > elements.Count - 1
                    || secondIndex < 0
                    || secondIndex > elements.Count - 1)
                {
                    elements.Insert(elements.Count / 2, $"-{turn}a");
                    elements.Insert(elements.Count / 2, $"-{turn}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    string elementToRemove = elements[firstIndex];

                    elements.Remove(elementToRemove);
                    elements.Remove(elementToRemove);

                    Console.WriteLine($"Congrats! You have found matching elements - {elementToRemove}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {turn} turns!");

                    return;
                }

                turn++;
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
