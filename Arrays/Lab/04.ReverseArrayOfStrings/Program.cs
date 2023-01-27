namespace _04.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine()
                .Split(" ");

            Console.WriteLine(string.Join(" ", texts.Reverse()));

        }
    }
}
