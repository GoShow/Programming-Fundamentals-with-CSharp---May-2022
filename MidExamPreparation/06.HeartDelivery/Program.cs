using System;
using System.Linq;

namespace _06.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] places = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            int place = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Love!")
                {
                    break;
                }

                string[] tokens = command.Split();

                int jump = int.Parse(tokens[1]);

                if (place + jump > places.Length - 1)
                {
                    place = 0;

                    CheckPlace(place, places);
                }
                else
                {
                    place += jump;

                    CheckPlace(place, places);
                }
            }

            Console.WriteLine($"Cupid's last position was {place}.");

            int failedPlaces = GetFailedPlaces(places);

            if (failedPlaces > 0)
            {
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
            else if (failedPlaces == 0)
            {
                Console.WriteLine("Mission was successful.");
            }

        }

        static void CheckPlace(int currentPosition, int[] places)
        {
            if (places[currentPosition] == 0)
            {
                Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
            }
            else
            {
                places[currentPosition] -= 2;

                if (places[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                }
            }
        }

        static int GetFailedPlaces(int[] places)
        {
            int failedPlaces = 0;

            foreach (var heart in places)
            {
                if (heart != 0)
                {
                    failedPlaces++;
                }

            }

            return failedPlaces;
        }
    }
}
