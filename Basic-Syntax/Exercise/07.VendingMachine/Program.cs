using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins, product;
            decimal currentMoney = 0M;
            while ((coins = Console.ReadLine()) != "Start")
            {
                // Valid coins are: 0.1, 0.2, 0.5, 1 and 2

                switch (coins)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        currentMoney += decimal.Parse(coins);
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }

            }
            decimal productPrice = 0M;
            while ((product = Console.ReadLine()) != "End")
            {


                switch (product)
                {
                    case "Nuts":
                        productPrice += 2.0M;
                        break;
                    case "Water":
                        productPrice += 0.7M;
                        break;
                    case "Crisps":
                        productPrice += 1.5M;
                        break;
                    case "Soda":
                        productPrice += 0.8M;
                        break;
                    case "Coke":
                        productPrice += 1.0M;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (currentMoney >= productPrice && currentMoney > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    currentMoney -= productPrice;
                    productPrice = 0;
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    productPrice = 0;
                }
                
            }
            
            Console.WriteLine($"Change: {currentMoney:f2}");
        }
    }
}

