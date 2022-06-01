using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] weekDays =
            {
                "Monday", //0
                "Tuesday", //1
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" //6
            };

            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                dayOfWeek--;
                Console.WriteLine(weekDays[dayOfWeek]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
