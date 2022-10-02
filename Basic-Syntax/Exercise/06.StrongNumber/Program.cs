using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumb = Console.ReadLine();           
            long result = 0L;

            for (int i = 0; i < inputNumb.Length; i++)
            {
                char currCh = inputNumb[i];
                int currDigit = (int)currCh - 48;

                long currDigitFactorial = 1L;
                for (int n = currDigit; n >= 1; n--)
                {
                    currDigitFactorial *= n;
                }
                
                result += currDigitFactorial;
            }
            
            Console.WriteLine((result==int.Parse(inputNumb))?"yes":"no");
            
        }
    }
}
