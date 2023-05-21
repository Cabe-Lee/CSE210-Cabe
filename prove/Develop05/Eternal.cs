using System;

public class Eternal : Goals
{
    public Eternal()
    {

    }
    public override void CreateNewGoal()
    {
        CreateNewGoalCommon();
        _goalType = "eternal";
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        return _goalPoints;
    }
    public override string GoalStringRepresentation(Goals goals)
    {
        string str = _goalType + ":" + _goalName + "," + _goalDescription + ","  + _goalPoints;
        return str;
    }
}