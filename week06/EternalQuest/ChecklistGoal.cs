using System;

public class ChecklistGoal : Goal
{
    private int _completionTimes;
    private int _setAmount;

    public override bool IsComplete()
    {
        if (_setAmount >= _completionTimes)
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

}