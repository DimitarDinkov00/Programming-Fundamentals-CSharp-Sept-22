namespace _01.DayOfWeek
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            Console.WriteLine(daysOfWeek[day - 1]);
        }
    }
}
