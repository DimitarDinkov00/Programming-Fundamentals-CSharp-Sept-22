using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= orders; i++)
            {

                double pricePerCapsule = double.Parse(Console.ReadLine());
                ushort days = ushort.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                Console.WriteLine($"The price for the coffee is: ${(days * capsulesCount) * pricePerCapsule:f2}");
                totalPrice += (days * capsulesCount) * pricePerCapsule;

            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
