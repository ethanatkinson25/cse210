using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listingActivity = new Listing();

        string choice = "";

        while (choice != "q")
        {
            // Console.Clear();
            Console.WriteLine("Welcome to the mindfulness program!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Write("> ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathingActivity.startMessage();
                breathingActivity.breathingIntervals();
                breathingActivity.endMessage();
            }
            else if (choice == "2")
            {
                reflectionActivity.startMessage();
                reflectionActivity.askPrompt();
                reflectionActivity.askQuestion();
                reflectionActivity.endMessage();
            }
            else if (choice == "3")
            {
                listingActivity.startMessage();

                listingActivity.endMessage();
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
                Thread.Sleep(2000);
            }
        }
        
    }
}