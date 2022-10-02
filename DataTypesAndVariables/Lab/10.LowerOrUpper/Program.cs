namespace _10.LowerOrUpper
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }

            if (char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
