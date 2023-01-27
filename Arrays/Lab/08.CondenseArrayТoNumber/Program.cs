namespace _08.CondenseArrayТoNumber
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArray = new int[input.Length - 1];

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = input[j] + input[j + 1];
                }
                input = condensedArray;
            }
            Console.WriteLine(condensedArray[0]);
        }
    }
}
