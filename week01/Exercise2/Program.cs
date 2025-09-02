using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        if (number >= 90)
        {
            Console.WriteLine($"Your grade is: {number}, A");
        }
        else if (number >= 80)
        {
            Console.WriteLine($"Your grade is: {number}, B");
        }
        else if (number >= 70)
        {
            Console.WriteLine($"Your grade is: {number}, C");
        }
        else if (number >= 60)
        {
            Console.WriteLine($"Your grade is: {number}, D");
        }
        else
        {
           Console.WriteLine($"Your grade is: {number}, F"); 
        }
        
    }
}