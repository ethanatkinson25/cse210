using System;

public class RunningActivity : Activity
{

    public RunningActivity(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
        _activityName = "Running";
    }
}