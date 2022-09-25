using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine($"{input} X {i} = {input*i}");

            //}

            int input = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
                i++;
            }
        }
    }
}
