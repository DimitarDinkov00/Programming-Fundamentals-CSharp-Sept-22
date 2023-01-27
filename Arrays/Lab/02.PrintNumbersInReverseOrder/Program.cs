namespace _02.PrintNumbersInReverseOrder
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(String.Join(" ", arr.Reverse()));

        }
    }
}
