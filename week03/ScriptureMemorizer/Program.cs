using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to press the enter key or type quit.
        // If the user types quit, the program should end.
        // If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again. (Hiding a word means that the word should be replace by underscores (_) and the number of underscores should match the number of letters in that word.)
        // The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
        // When all words in the scripture are hidden, the program should end. (The final display of the scripture should show the scripture with all words hidden.)

        var scripture = new Scripture();
        string quit_status = "";
        string input;
        while (quit_status != "q")
        {
            Console.WriteLine("Welcome to the Scripture Guessing Program!");
            Console.WriteLine();
            Console.WriteLine("Here is your scripture to memorize:");
            Console.WriteLine();
            Console.WriteLine($"{scripture.printFullScripture()}");
            // Console.WriteLine("There is a scripture here_______");
            Console.WriteLine();
            Console.WriteLine("Press Enter or Space to continue. Press 'q' to quit;");
            Console.Write("> ");
            input = Console.ReadLine();
            if (input == "" | input == " ")
            {
                // Hide a random word or words
                // Print Verse with hidden words
                scripture.breakVerse();
            }
            else if (input == "q")
            {
                quit_status = "q";
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }
}