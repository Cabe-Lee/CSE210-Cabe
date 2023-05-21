using System;

public class Checklist : Goals
{
    public Checklist()
    {
        
    }
    public override void CreateNewGoal()
    {
        CreateNewGoalCommon();
        _goalType = "checklist";
        Console.Write("How many times does this goal need to be acomplished for a bonus? ");
        _goalBonusTime = GetStringToInt();
        Console.Write("What is the postive or negative bonus points for acomplishing it that many times? ");
        _goalBonusPoints = GetStringToInt();
        _goalBonusTimeTotal = 0;
        _goalRecord = " ";
    }
    public override int RecordEvent()
    {
        _goalBonusTimeTotal++;
        int points = 0;
        if (_goalBonusTimeTotal == _goalBonusTime)
        {
            _goalRecord = "X";
            points = _goalPoints + _goalBonusPoints;
        }
        else
        {
            points = _goalPoints;
        }
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }
    public override string GoalStringRepresentation(Goals goals)
    {
        string str = _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _goalBonusPoints + "," + _goalBonusTime + "," + _goalBonusTimeTotal;
        return str;
    }
}