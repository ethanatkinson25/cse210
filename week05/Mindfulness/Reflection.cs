using System;

public class Reflection : Activity
{
    private int _questionCount = 0;
    public Reflection()
    {
        _activityName = "Reflection";
        _description = "This activity will prompt you with questions regarding a time in your life. This will also ask you about your feeling abotu that moment and what it means to you now.";
        _durationInSec = 1;
    }

    private string generateRandomPrompt()
    {
        string[] randomPromptChoice = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time where you got joy and satisfaction out of what you were doing."
        };

        Random random = new Random();
        int randomIndex = random.Next(randomPromptChoice.Length);


        string selected = randomPromptChoice[randomIndex];
        return selected;
    }

    private string generateRandomQuestion()
    {
        string[] randomQuestionChoice = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        int randomIndex = random.Next(randomQuestionChoice.Length);

        string selected = randomQuestionChoice[randomIndex];
        return selected;
    }

    public void askPrompt()
    {
        string prompt = generateRandomPrompt();
        string input = " ";

        while (input != "")
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"{prompt} ");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.Write("> ");
            input = Console.ReadLine();
        }
        Console.WriteLine("Now ponder each question as they realte to your expirience.");
        Console.Write("You may begin in...");
        countDown();
    }

    public void askQuestion()
    {
        _questionCount = 0;
        string question;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationInSec);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            question = generateRandomQuestion();
            Console.Write($"{question}  ");
            loadingAnimation();
            Console.WriteLine();
            _questionCount += 1;
            currentTime = DateTime.Now;
        }

    }

}