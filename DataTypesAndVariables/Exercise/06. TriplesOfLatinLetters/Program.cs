using System;

namespace _06._TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int f = 0; f < input; f++)
            {
                char firstCh = (char)('a' + f);
                for (int s = 0; s < input; s++)
                {
                    char secondCh = (char)('a' + s);
                    for (int t = 0; t < input; t++)
                    {
                        char thirdCh = (char)('a' + t);
                        Console.Write($"{firstCh}{secondCh}{thirdCh}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
