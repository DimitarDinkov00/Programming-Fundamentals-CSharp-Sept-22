using System;

namespace _08.DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = 3;
            while (numb <= 100)
            {
                Console.WriteLine(numb);
                numb += 3;
            }
        }
    }
}
