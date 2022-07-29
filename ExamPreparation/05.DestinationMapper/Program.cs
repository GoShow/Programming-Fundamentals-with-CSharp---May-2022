using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\/=])(?<destination>[A-Z][A-Za-z]{2,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            string[] destinations = matches.Select(m => m.Groups["destination"].Value).ToArray();
            int travelPoints = destinations.Select(d => d.Length).ToArray().Sum();

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
