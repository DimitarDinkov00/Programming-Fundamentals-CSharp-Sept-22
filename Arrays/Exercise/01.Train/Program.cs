using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            int sum = train.Sum();
            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
