using System;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxPeoplePerWagon = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < maxPeoplePerWagon; j++)
                {
                    lift[i]++;
                    peopleWaiting--;

                    if (peopleWaiting == 0)
                    {
                        if (lift.Sum() < lift.Length * maxPeoplePerWagon)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(' ', lift));

                        return;
                    }
                }
            }

            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(' ', lift));
        }
    }
}
