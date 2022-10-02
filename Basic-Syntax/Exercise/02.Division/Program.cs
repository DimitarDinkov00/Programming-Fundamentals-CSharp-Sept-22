using System;

namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggestDivision = 0;
            //You will be given an integer, write a program which checks
            //if the given integer is divisible by 2 or 3,  or 6, or 7, or 10 without a reminder.
            //You should always take the bigger division:

            if (number % 10 == 0)
            {
                biggestDivision = 10;
            }
            else if (number % 7 == 0)
            {
                biggestDivision = 7;
            }
            else if (number % 6 == 0)
            {
                biggestDivision = 6;
            }
            else if (number % 3 == 0)
            {
                biggestDivision = 3;
            }
            else if (number % 2 == 0)
            {
                biggestDivision = 2;
            }

            if (biggestDivision > 0)
            {
                Console.WriteLine($"The number is divisible by {biggestDivision}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
