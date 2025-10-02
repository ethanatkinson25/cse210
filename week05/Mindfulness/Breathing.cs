using System;

public class Breathing : Activity
{
    public Breathing()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you to practice paced breathing. This will help clear you mind and focus.";
        _durationInSec = 1;
    }

    private void loadingAnimation()
    {
        DateTime currentPauseTime = DateTime.Now;
        DateTime pauseTime = currentPauseTime.AddSeconds(5);

        currentPauseTime = DateTime.Now;
        if (currentPauseTime < pauseTime)
        {
            Console.Write("/");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void breathingIntervals()
    {
        // int durationInMiliseconds = _durationInSec * 1000;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationInSec);

        // Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        DateTime currentTime = DateTime.Now;
        // DateTime pauseTime = currentTime.AddSeconds(5);
        while (currentTime < futureTime)
        {
            int breatheTime = 4;
            // currentTime = DateTime.Now;
            // if (currentTime < pauseTime)
            // {
            //     Console.Write("/");

            //     Thread.Sleep(500);

            //     Console.Write("\b \b");
            //     Console.Write("|");

            //     Thread.Sleep(500);

            //     Console.Write("\b \b");
            //     Console.Write("-");
            // }
            Console.Write("Breath in... ");
            while (breatheTime != 0)
            {
                Console.Write(breatheTime);
                breatheTime = breatheTime - 1;
                Console.Write("\b \b");
                loadingAnimation();
            }
            Console.WriteLine();

            Console.Write("Breathe out... ");
            breatheTime = 4;
            while (breatheTime != 0)
            {
                Console.Write(breatheTime);
                breatheTime = breatheTime - 1;
                Console.Write("\b \b");
                loadingAnimation();
            }
            Console.WriteLine();
            
        }

    }
}