namespace _07.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Debug example values:
            //Input: 2 1 1 2 3 3 2 2 2 1
            //Expected output: 2 2 2
            //************************


            int[] array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int sequenceSize = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumb = array[j];

                    if (currentNumber == rightNumb)
                    {
                        sequenceSize += 1;

                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = sequenceSize;
                    bestSequenceNumber = currentNumber;
                }
            }
            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }
        }
    }
}
