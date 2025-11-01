using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random magic_number = new Random();
        while (true)
        {
            int _magic_number = magic_number.Next(1, 100);
            int number_of_tries = 0;
            while (true)
            {
                number_of_tries += 1;
                Console.WriteLine($"Number of Tries: {number_of_tries}.");
                Console.WriteLine("Enter Guess: "); string user_guess = Console.ReadLine();
                int _user_guess = int.Parse(user_guess);

                if (_user_guess < _magic_number)
                {
                    Console.WriteLine("Higher");
                }

                else if (_user_guess > _magic_number)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed right!");
                    break;
                }
            }
            Console.Write("Would you like to play again? (yes/no)"); string user_response = Console.ReadLine().ToLower();
            if (user_response == "no")
            {
                Console.WriteLine("Exiting...");
                return;
            }
            else if (user_response == "yes")
            {
                continue;
            }

            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}