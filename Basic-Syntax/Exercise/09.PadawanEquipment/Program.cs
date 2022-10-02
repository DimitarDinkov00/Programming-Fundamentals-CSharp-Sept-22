namespace _09.PadawanEquipment
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double lightsabersTenPercentUp = Math.Ceiling(studentsCount * 0.10); //Add 10% more Lightsabers

            double totalCosts = (priceOfLightsabers * (studentsCount + lightsabersTenPercentUp))
                + (priceOfRobes * studentsCount) + (priceOfBelts * (studentsCount - studentsCount / 6));

            if (totalCosts <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCosts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCosts - money:f2}lv more.");
            }

        }
    }
}
