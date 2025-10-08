using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void setIsComplete(bool completeStatus)
    {
        _isComplete = completeStatus;
    }
}