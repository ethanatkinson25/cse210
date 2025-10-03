using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _durationInSec;

    public Activity()
    {
        _activityName = "Default Activity";
        _description = "A description of the activity that the user chose.";
        _durationInSec = 1;
    }

    public void startMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity! \n{_description}");
        Console.WriteLine();
        Console.WriteLine("How long would you like to participate in this activity in seconds?");
        Console.Write("> ");
        string input = Console.ReadLine();
        _durationInSec = int.Parse(input);

    }

    public void endMessage()
    {
        Console.WriteLine("Good job!");
        loadingAnimation();
        Console.WriteLine($"You completed {_durationInSec} seconds of the {_activityName} activity!");
    }

    protected void loadingAnimation()
    {
        DateTime currentPauseTime = DateTime.Now;
        DateTime pauseTime = currentPauseTime.AddSeconds(5);

        currentPauseTime = DateTime.Now;
        while (currentPauseTime < pauseTime)
        {
            Console.Write("\b \b");
            Console.Write("|");


            Thread.Sleep(600);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(600);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(600);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(600);

            currentPauseTime = DateTime.Now;
            Console.Write("\b \b");
        }
    }
    
    protected void countDown()
    {
        int breatheTime = 4;

        while (breatheTime != 0)
        {
            Console.Write(breatheTime);
            breatheTime = breatheTime - 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}