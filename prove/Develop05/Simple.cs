using System;

public class Simple : Goals
{
    public Simple()
    {

    }
    public override void CreateNewGoal()
    {
        CreateNewGoalCommon();
        _goalType = "simple";
    }
    public override int RecordEvent()
    {
        _goalRecord = "X";
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        return _goalPoints;
    }
    public override string GoalStringRepresentation(Goals goals)
    {
        string str = _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _goalRecord;
        return str;
    }
}