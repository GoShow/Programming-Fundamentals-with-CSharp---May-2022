using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            string[] words = Console.ReadLine()
                .Split()
                .Select(word => word.ToLower())
                .ToArray();

            foreach (var word in words)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 0);
                }

                wordCounts[word]++;
            }

            string[] oddCountWords = wordCounts
                .Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", oddCountWords));
        }
    }
}
