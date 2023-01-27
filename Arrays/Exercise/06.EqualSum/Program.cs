namespace _06.EqualSum
{
    using System.Linq;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbs = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            bool exist = false;
            for (int i = 0; i < numbs.Length; i++)
            {
                int leftSum = 0;
                for (int r = i - 1; r >= 0; r--)
                {
                    leftSum += numbs[r];
                }
                int rightSum = 0;
                for (int r = i + 1; r < numbs.Length; r++)
                {
                    rightSum += numbs[r];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
