using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A count of people who are going on vacation.
            int counOfPeople = int.Parse(Console.ReadLine());
            //Type of the group(Students, Business or Regular).
            string typeOfGroup = Console.ReadLine();
            //The day of the week which the group will stay on(Friday, Saturday or Sunday).
            string dayOfWeek = Console.ReadLine();
            double price = 0.00;
            //|----------|---------|------------|----------|
            //|  price:  | Friday  |  Saturday  |  Sunday  |
            //|----------|---------|------------|----------|
            //|Students  |  8.45   |   9.80     |   10.46  |
            //| ---------|---------|------------|----------|
            //|Business  |  10.90  |   15.60    |    16    |
            //| ---------|---------|------------|----------|
            //|Regular   |   15    |    20      |  22.50   |
            //|----------|---------|------------|----------|

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    //For Business – if the group is 100 or more people, 10 of the people stay for free.
                    if (typeOfGroup == "Business" && counOfPeople >= 100)
                    {
                        counOfPeople -= 10;
                    }
                    switch (dayOfWeek)
                    {

                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.00;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20.00;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;

            }
            double totalPrice = counOfPeople * price;

            //For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            if (typeOfGroup == "Students" && counOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            //For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.
            if (typeOfGroup == "Regular" && counOfPeople >= 10 && counOfPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
