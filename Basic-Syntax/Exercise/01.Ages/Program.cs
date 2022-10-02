using System;

namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string output = "";

            //0 - 2 – baby
            //3 - 13 – child
            //14 - 19 – teenager
            //20 - 65 – adult
            //>= 66 – elder

            if (age >= 0 && age < 3)
            {
                output = "baby";
            }
            else if (age >= 3 && age < 14)
            {
                output = "child";
            }
            else if (age >= 14 && age < 20)
            {
                output = "teenager";
            }
            else if (age >= 20 && age < 66)
            {
                output = "adult";
            }
            else if (age >= 66)
            {
                output = "elder";
            }

            Console.WriteLine(output);

        }
    }
}
