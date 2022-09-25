using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{input} X {times} = {input * times}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {

                    Console.WriteLine($"{input} X {times} = {input * times}");
                    times++;
                }
            }
        }
    }
}
