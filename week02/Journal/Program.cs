using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //This file will run all objects and orchestrate the program
        int choice = 0;
        string inputChoice = "";
        var journal = new Write();
        while (choice != 5)
        {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            inputChoice = Console.ReadLine();
            choice = int.Parse(inputChoice);

            if (choice == 1)
            {
                journal.write();
                journal.TemporarySave();

            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                //Code goes here
            }
            else if (choice == 4)
            {
                //Code goes here
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the journal program!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }

}

