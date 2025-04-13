using System;

namespace PasswordConfirmation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Hello, please enter your username: ");
            string username = Console.ReadLine();

           
            Console.Write($"hello, {username} Please enter a new password: ");
            string password = Console.ReadLine();

            
            Console.WriteLine("Please confirm your password:");

            bool passwordCorrect = false;
            int attemptsLeft = 3;

            while (attemptsLeft > 0 && !passwordCorrect)
            {
                Console.Write($"Enter password again ({attemptsLeft} attempts left): ");
                string confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    passwordCorrect = true;
                    Console.WriteLine("Password confirmed successfully!");
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine("Password does not match!");
                }
            }

            if (!passwordCorrect)
            {
                Console.WriteLine("Too many wrong attempts. Please try again later.");
            }

            Console.WriteLine("Program ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}