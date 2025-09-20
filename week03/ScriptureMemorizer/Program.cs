using System;
// I added a feature that allows the reference class to randomly select a verse (or set of verses) for the user to memorize each time the program starts

class Program
{
    static void Main(string[] args)
    {

        var scripture = new Scripture();
        string quit_status = "";
        string input;

        scripture.breakVerse();
        while (quit_status != "q")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Guessing Program!");
            Console.WriteLine();
            Console.WriteLine("Here is your scripture to memorize:");
            Console.WriteLine();
            scripture.printFullScripture();
            Console.WriteLine();
            Console.WriteLine("Press Enter or Space to continue. Press 'q' to quit;");
            Console.Write("> ");
            input = Console.ReadLine();
            if (input == "")
            {
                if (scripture.isCompletelyHidden() == false)
                {
                    scripture.hideWord();
                }
                else
                {
                    break;
                }
            }
            else if (input == "q")
            {
                quit_status = "q";
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
                Console.Write("> ");
                input = Console.ReadLine();
            }
        }
    }
}