using System;
using System.Linq;
namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumb = arr[i];
                bool isTopInt = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNumb = arr[j];
                    if (nextNumb >= currentNumb)
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(currentNumb + " ");
                }
            }
        }
    }
}
