using System;

class Program
{
    static void Main(string[] args)
    {
        //This is a comment
        //This is a change
        Console.Write("What is your name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is: {first_name}, {last_name}.");
    }
}