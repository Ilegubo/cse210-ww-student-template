using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        int digit_guess;
        string guess;
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        Console.Write("What is the magic number? ");
        do
        {
            Console.Write("What is your guess? "); guess = Console.ReadLine();
            digit_guess = int.Parse(guess);
            {
                if (digit_guess < magic_number)
                {
                    Console.WriteLine("Higher");
                    continue;
                }

                else if (digit_guess > magic_number)
                {
                    Console.WriteLine("Lower");
                    continue;
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }
        } while (digit_guess != magic_number);
    }
}