﻿namespace _03.Elevator
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int numberOfCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            Console.WriteLine(numberOfCourses);

        }
    }
}
