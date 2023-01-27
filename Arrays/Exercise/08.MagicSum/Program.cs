using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Input:
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targerSum = int.Parse(Console.ReadLine());

            for (int r = 0; r < array.Length; r++)
            {
                for (int i = r + 1; i < array.Length; i++)
                {
                    if (array[r] + array[i] == targerSum)
                    {
                        Console.WriteLine($"{array[r]} {array[i]}");
                        break;
                    }
                }
            }
        }
    }
}
