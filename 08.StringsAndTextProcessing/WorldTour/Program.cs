using System;

namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Travel")
                {
                    break;
                }

                string[] tokens = command.Split(':');
                string action = tokens[0];

                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string newStop = tokens[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, newStop);
                        }

                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (startIndex >= 0
                            && startIndex < stops.Length
                            && endIndex >= 0
                            && endIndex < stops.Length)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        }

                        break;
                    case "Switch":
                        string oldString = tokens[1];
                        string newString = tokens[2];

                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                        }

                        break;
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
