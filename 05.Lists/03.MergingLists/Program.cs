using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int biggerCount = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < biggerCount; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
