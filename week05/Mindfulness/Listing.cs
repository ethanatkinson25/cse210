using System;
using System.Net;

public class Listing : Activity
{
    private List<string> _responseList = new List<string>();
    private List<int> _previousQuestionIndex = new List<int>();
    public Listing()
    {
        _activityName = "Listing";
        _description = "This activity will have you reflect on a moment in your life and have you recall all the good about it.";
        _durationInSec = 1;
    }

    private string generateRandomQuestion()
    {
        Random random = new Random();
        int randomIndex;
        string selected;
        bool isDuplicate = true;
        do
        {
            string[] randomQuestionChoice = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            randomIndex = random.Next(randomQuestionChoice.Length);
            selected = randomQuestionChoice[randomIndex];


            for (int i = 0; i < _previousQuestionIndex.Count; i++)
            {
                if (_previousQuestionIndex[i] == randomIndex)
                {
                    isDuplicate = true;
                    break;
                }
                else
                {
                    isDuplicate = false;
                }
            }
        } while (isDuplicate == true);
        _previousQuestionIndex.Add(randomIndex);

        return selected;
    }

    public void listResponse()
    {
        string prompt = generateRandomQuestion();
        string response;
        int responseCount = 0;

        Console.WriteLine("List all the positive things you can about the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"{prompt} ");
        Console.WriteLine();
        loadingAnimation();
        loadingAnimation();
        Console.Write("You may begin in... ");
        countDown();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationInSec);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            _responseList.Add(response);
            currentTime = DateTime.Now;
            responseCount += 1;
        }
        displayResponse(responseCount);
    }

    private void displayResponse(int responseCount)
    {
        Console.WriteLine($"You entered in: {responseCount} things! Well done!");
    }
}