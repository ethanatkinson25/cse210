using System;

public abstract class Activity
{
    protected string _activityName;
    protected double _distance;
    protected double _minutes;

    public virtual double calculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }
    public virtual double calculatePace()
    {
        double pace = _minutes / _distance;
        return pace;
    }

    public virtual void displaySummary()
    {
        Console.WriteLine($"{_activityName}: ({_minutes} min) - {getDistance()}km, Speed: {calculateSpeed()}kph, Pace: {calculatePace()} min per km");
    }

    public double getDistance()
    {
        return _distance;
    }
}