using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {

            int sum = 0;
            int currNumb = i;
            bool isSpecial = false;
                
                while (currNumb > 0)
                {
                    sum += currNumb % 10;
                    currNumb /= 10;
                }
                
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
