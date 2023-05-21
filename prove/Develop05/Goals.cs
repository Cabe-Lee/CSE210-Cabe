using System;

public class Goals
{
    public string _goalType;
    public string _goalName;
    public string _goalDescription;
    public int _goalPoints;
    public string _goalRecord;
    public int _goalBonusPoints;
    public int _goalBonusTime;
    public int _goalBonusTimeTotal;
    public int _goalCount;

    public Goals()
    {
        
    }
    public virtual void CreateNewGoal()
    {
        
    }
    public void CreateNewGoalCommon()
    {
        Console.WriteLine("Please enter either a postive or negative(e.g. minus points -10) goal.");
        Console.Write("What is the name of the goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short desription of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of postive or negative points with this goal? ");
        _goalPoints = GetStringToInt();
        _goalRecord = " ";
    }
    public int GetStringToInt()
    {
        string str = "";
        int valid = 1;
        int num = 0;
        while (valid == 1)
        {
            str = Console.ReadLine();
            bool success = int.TryParse(str, out num);
            if (success) 
            {
                valid = 0;
            }
            else
            {
                Console.WriteLine("ERROR: Please enter an interger. ");
            }
        }
        return num;
    }
    public virtual int RecordEvent()
    {
        return 1;
    }
    public virtual string GoalStringRepresentation(Goals goals)
    {
        string str = "";
        return str;
    }
}