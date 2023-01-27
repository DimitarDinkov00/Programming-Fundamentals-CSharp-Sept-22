namespace _06.EvenAndOddSubtraction
{
    using System;
    using System.Linq;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }

            Console.WriteLine(even - odd);

        }
    }
}
