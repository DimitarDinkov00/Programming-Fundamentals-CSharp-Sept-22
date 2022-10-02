using System;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumb = int.Parse(Console.ReadLine());
            int endNumb = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNumb; i <= endNumb; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
