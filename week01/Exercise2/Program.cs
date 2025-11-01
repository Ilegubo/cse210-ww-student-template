using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? "); string score = Console.ReadLine();
        int grade = int.Parse(score);
        int last_digit = grade % 10;
        string sign, letter;
        if (last_digit >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "-";
        }

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (!(grade <= 50 || grade >= 97))
        {
            Console.WriteLine(letter + sign);
        }
        else
        {
            Console.WriteLine(letter);
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have successfully passed the course.");
        }
        
        else
        {
            Console.WriteLine("Sorry, better luck next time.");
        }
        
    }
}