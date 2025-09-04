using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine();
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the squared number you entered is: {squaredNumber}.");
    }
}