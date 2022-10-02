namespace _10.RageExpenses
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = ((games / 2) * headsetPrice) + ((games / 3) * mousePrice) + ((games / 6) * keyboardPrice) + ((games / 12) * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
