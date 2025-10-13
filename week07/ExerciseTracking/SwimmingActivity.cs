using System;

public class SwimmingActivity : Activity
{
    private int _laps;


    public SwimmingActivity(double minutes, int laps)
    {
        _minutes = minutes;
        _laps = laps;
        _activityName = "Swimming";
    }

    public double calculateDistance()
    {
        double distance = _laps * 50 / 1000;
        _distance = distance;
        return distance;
    }

    public override void displaySummary()
    {
        Console.WriteLine($"{_activityName}: ({_minutes} min) - Distance: {calculateDistance()}km, Speed: {calculateSpeed()}kph, Pace: {calculatePace()} min per km");
    }
}