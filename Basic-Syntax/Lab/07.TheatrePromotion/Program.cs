using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0.0;
            //input:
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 122)
            {
                //Day / Age  ||  0 <= age <= 18   || 18 < age <= 64 || 64 < age <= 122
                //Weekdend    ||      12$	          ||      18$       ||  	12$ 
                if (typeOfDay == "weekday")
                {
                    if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else
                    {
                        price = 12;
                    }
                }
                //Day / Age  ||  0 <= age <= 18   || 18 < age <= 64 || 64 < age <= 122
                //Weekdend    ||      15$	          ||      20$       ||  	15$ 
                else if (typeOfDay == "weekend")
                {
                    if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else
                    {
                        price = 15;
                    }
                }
                //Day / Age  ||  0 <= age <= 18   || 18 < age <= 64 || 64 < age <= 122
                //Holiday    ||      5$	          ||      12$       ||  	10  
                else if (typeOfDay == "holiday")
                {
                    if (age > 0 && age <= 18)
                    {
                        price = 5;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }

                }

                //reult:
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
