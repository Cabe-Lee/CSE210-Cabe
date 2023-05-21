using System;

public class File
{
    public int _totalPoints;
    public int _numGoals;
    

    public File()
    {
        
    }
    public string DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");
        string options = Console.ReadLine();
        return options;
    }
    public string SelectGoals()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would like to create? ");
        string goal = Console.ReadLine();
        return goal;
    }
    public void ListGoals(List<Goals> goals)
    {
        foreach (Goals g in goals)
        {
            if (g._goalType != "checklist")
            {
                Console.WriteLine($" [{g._goalRecord}] {g._goalName} ({g._goalDescription})");
            }
            else
            {
                Console.WriteLine($" [{g._goalRecord}] {g._goalName} ({g._goalDescription}) -- Currently completed: {g._goalBonusTimeTotal}/{g._goalBonusTime}");
            }
        }
    }
    public void SaveGoals(List<Goals> goals)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string str = "";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goals g in goals)
            {
                str = g.GoalStringRepresentation(g);
                outputFile.WriteLine(str);
            }
        }
    }
    public List<Goals> LoadGoals()
    {
        Console.Write("What is the filename to load the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Goals> goals =  new List<Goals>();
        int i = 0;
        int _numGoals = 0;
        foreach (string line in lines)
        {
            if (i == 0)
            {
                _totalPoints = int.Parse(line);
            }
            else
            {
                string[] parts = line.Split(":");
                if (parts[0] == "simple")
                {
                    goals.Add(new Simple());
                    goals[_numGoals]._goalType = parts[0];
                    string[] partsTwo = parts[1].Split(",");
                    goals[_numGoals]._goalName = partsTwo[0];
                    goals[_numGoals]._goalDescription = partsTwo[1];
                    goals[_numGoals]._goalPoints = int.Parse(partsTwo[2]);
                    goals[_numGoals]._goalRecord = partsTwo[3];
                    
                }
                else if (parts[0] == "eternal")
                {
                    goals.Add(new Eternal());
                    string[] partsTwo = parts[1].Split(",");
                    goals[_numGoals]._goalType = parts[0];
                    goals[_numGoals]._goalName = partsTwo[0];
                    goals[_numGoals]._goalDescription = partsTwo[1];
                    goals[_numGoals]._goalPoints = int.Parse(partsTwo[2]);
                    goals[_numGoals]._goalRecord = " ";
                }
                else if (parts[0] == "checklist")
                {
                    goals.Add(new Checklist());
                    string[] partsTwo = parts[1].Split(",");
                    goals[_numGoals]._goalType = parts[0];
                    goals[_numGoals]._goalName = partsTwo[0];
                    goals[_numGoals]._goalDescription = partsTwo[1];
                    goals[_numGoals]._goalPoints = int.Parse(partsTwo[2]);
                    goals[_numGoals]._goalBonusPoints = int.Parse(partsTwo[3]);
                    goals[_numGoals]._goalBonusTime = int.Parse(partsTwo[4]);
                    goals[_numGoals]._goalBonusTimeTotal = int.Parse(partsTwo[5]);
                    if (goals[_numGoals]._goalBonusTimeTotal >= goals[_numGoals]._goalBonusTime)
                    {
                        goals[_numGoals]._goalRecord = "X";
                    }
                    else 
                    {
                        goals[_numGoals]._goalRecord = " ";
                    }
                }
                _numGoals++;
            }
            i++;
        }
        goals[0]._goalCount = _numGoals;
        return goals;
    }
}