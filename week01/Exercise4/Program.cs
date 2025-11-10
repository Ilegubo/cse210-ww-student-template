using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter number: "); string number = Console.ReadLine();
            int _number = int.Parse(number);
            if (_number != 0)
            {
                numbers.Add(_number);
            }

            else
            {
                int sum = 0, length = numbers.Count;
                foreach ( int element in numbers)
                {
                    //sum of numbers in list
                    sum += element;
                    Console.WriteLine($"The sum is: {numbers}");

                    //Average of numbers in the list
                    float avg_numbers = sum / length;
                    Console.WriteLine($"The average is: {avg_numbers}");

                    //The largest of the numbers in the list
                    int largest = numbers.Max();
                    Console.WriteLine($"The largest number is: {largest}");

                }
                return;
            }
        }
    }
}