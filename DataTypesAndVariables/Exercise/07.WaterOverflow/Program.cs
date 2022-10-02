using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int currentWater = 0;
            for (int i = 0; i < n; i++)
            {
                int quantityPouredWater = int.Parse(Console.ReadLine());


                if (currentWater+quantityPouredWater > capacity)
                {

                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentWater += quantityPouredWater;

                }

            }
            Console.WriteLine(currentWater);
        }
    }
}
