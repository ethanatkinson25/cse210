using System;

public class ChecklistGoal : Goal
{
    private int _completionTimes;
    private int _setAmount;



    public override bool IsComplete()
    {
        if (_setAmount <= _completionTimes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setCompletionAmount(int completions)
    {
        _setAmount = completions;
    }

    public int getSetAmount()
    {
        return _setAmount;
    }

    public void setAttemptAmount(int desiredAmount)
    {
        _completionTimes = desiredAmount;
    }

    public int getCompletionTimes()
    {
        return _completionTimes;
    }

}