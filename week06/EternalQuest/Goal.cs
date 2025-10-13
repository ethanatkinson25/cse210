using System;
using System.Dynamic;

public abstract class Goal
{
    protected string _goalName;
    protected int _points;
    protected string _goalDescription;

    public string getGoalName()
    {
        return _goalName;
    }

    public int getPoints()
    {
        return _points;
    }

    public string getGoalDescription()
    {
        return _goalDescription;
    }

    public void setGoalName(string name)
    {
        _goalName = name;
    }

    public void setPoints(int points)
    {
        _points = points;
    }

    public void setGoalDescription(string description)
    {
        _goalDescription = description;
    }

    public abstract bool IsComplete();

}