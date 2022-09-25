using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = 1;


            while (numb % 2 != 0)
            {
                numb = int.Parse(Console.ReadLine());
                if (numb % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(numb)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
