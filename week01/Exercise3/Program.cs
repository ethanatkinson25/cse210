using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the number!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine();
        Console.Write("Enter your guess: ");
        string response = Console.ReadLine();
        int guess = int.Parse(response);
        int attempts = 1;

        while (guess != number)
        {
            attempts = attempts = 1;
            if (guess > number)
            {
                Console.WriteLine("Guess lower!");
                Console.Write("Enter your guess: ");
                response = Console.ReadLine();
                guess = int.Parse(response);

            }
            else if (guess < number)
            {
                Console.WriteLine("Guess Higher!");
                response = Console.ReadLine();
                guess = int.Parse(response);

            }
        }
        Console.WriteLine("You guessed right!");
        Console.WriteLine($"Your total amount of attempts are: {attempts}");
    }
}