using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? "); string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? "); string number = Console.ReadLine();
        int _number = int.Parse(number);

        return _number;
    }

    static int SquareNumber(int base_number)
    {
        return base_number * base_number;
    }
    
    static void DisplayResult()
    {
        Console.Write("What is your name? "); string name = Console.ReadLine();
        Console.Write("Enter a square: "); string square = Console.ReadLine();

        Console.WriteLine($"Your name is {name} and the square number is {square}");
    }
}
