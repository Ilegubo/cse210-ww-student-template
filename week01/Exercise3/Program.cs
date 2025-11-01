using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        int digit_guess, number_of_tries=0;
        string guess;
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        Console.Write("What is the magic number? ");
        do
        {
            Console.Write("What is your guess? "); guess = Console.ReadLine();
            digit_guess = int.Parse(guess);
            number_of_tries += 1;
            Console.WriteLine($"Number of attempts {number_of_tries}");
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