namespace _07.EqualArrays
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondNumbs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < firstNumbs.Length; i++)
            {
                sum += firstNumbs[i];

                if (firstNumbs[i] != secondNumbs[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;

                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
