using System;

public class BikesActivity : Activity
{

    public BikesActivity(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
        _activityName = "Bikes";
    }
}