using System;

public class Breathing : Activity
{
    public Breathing()
    {
        _activityName = "Breathing";
        _description = "This activity will help you to practice paced breathing. This will help clear you mind and focus.";
        _durationInSec = 1;
    }


    public void breathingIntervals()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationInSec);

        Console.Clear();
        Console.Write("Get ready...  ");
        loadingAnimation();
        Console.WriteLine();
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breathe in... ");
            countDown();
            Console.WriteLine();

            Console.Write("Breathe out... ");
            countDown();
            currentTime = DateTime.Now;
            Console.WriteLine();

        }
    }
}