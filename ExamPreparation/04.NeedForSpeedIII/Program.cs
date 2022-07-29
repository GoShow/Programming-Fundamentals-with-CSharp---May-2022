using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carProperties = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car
                {
                    Brand = carProperties[0],
                    Mileage = int.Parse(carProperties[1]),
                    Fuel = int.Parse(carProperties[2])
                };

                cars.Add(car);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                string[] tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];

                switch (action)
                {
                    case "Drive":
                        Drive(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), cars);
                        break;
                    case "Refuel":
                        Refuel(tokens[1], int.Parse(tokens[2]), cars);
                        break;
                    case "Revert":
                        Revert(tokens[1], int.Parse(tokens[2]), cars);
                        break;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Brand} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        static void Drive(string brand, int distance, int fuel, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);

            if (car.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");

                return;
            }

            car.Mileage += distance;
            car.Fuel -= fuel;

            Console.WriteLine($"{brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (car.Mileage >= 100_000)
            {
                cars.Remove(car);
                Console.WriteLine($"Time to sell the {brand}!");
            }
        }

        static void Refuel(string brand, int fuel, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);

            int originalFuel = car.Fuel;

            car.Fuel += fuel;

            if (car.Fuel > 75)
            {
                car.Fuel = 75;
            }

            Console.WriteLine($"{brand} refueled with {car.Fuel - originalFuel} liters");
        }

        static void Revert(string brand, int kilometers, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);

            car.Mileage -= kilometers;

            Console.WriteLine($"{brand} mileage decreased by {kilometers} kilometers");

            if (car.Mileage < 10_000)
            {
                car.Mileage = 10_000;
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
