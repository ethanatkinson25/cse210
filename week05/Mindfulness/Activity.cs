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
        Console.WriteLine($"You completed {_durationInSec} seconds of the {_activityName} activity!");
    }
}