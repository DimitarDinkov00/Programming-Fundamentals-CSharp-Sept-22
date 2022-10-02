using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;

            }
            string enterPass;
            int attemptCount = 0;
            while ((enterPass = Console.ReadLine()) != password)
            {

                if (attemptCount >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                attemptCount++;
            }

            Console.WriteLine((enterPass == password) ? $"User {username} logged in." : "");
        }
    }
}
