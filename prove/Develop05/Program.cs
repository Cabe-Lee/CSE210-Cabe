using System;

class Program
{
    static void Main(string[] args)
    {
        File file = new File();
        file._totalPoints = 0;
        List<Goals> goalList =  new List<Goals>();
        file._numGoals = 0;

        int valid = 1;
        while (valid == 1)
        {
            Console.WriteLine($"\nYou have {file._totalPoints} points.\n");
            
            string options = file.DisplayMenu();
            if (options == "1")
            {
                string goal = "";
                goal = file.SelectGoals();
                if (goal == "1")
                {
                    goalList.Add(new Simple());
                    goalList[file._numGoals].CreateNewGoal();
                    file._numGoals++;
                }
                else if (goal == "2")
                {
                    goalList.Add(new Eternal());
                    goalList[file._numGoals].CreateNewGoal();
                    file._numGoals++;
                }
                else if (goal == "3")
                {
                    goalList.Add(new Checklist());
                    goalList[file._numGoals].CreateNewGoal();
                    file._numGoals++;
                }
                else
                {
                    Console.WriteLine("Please select 1 - 3.");
                }
            }
            else if (options == "2")
            {
                file.ListGoals(goalList);
            }
            else if (options == "3")
            {
                file.SaveGoals(goalList);
            }
            else if (options == "4")
            {
                goalList.Clear();
                goalList = file.LoadGoals();
                file._numGoals = goalList[0]._goalCount;
            }
            else if (options == "5")
            {
                if (goalList.Count >= 1)
                {
                    int i = 0;
                    foreach (Goals g in goalList)
                    {
                        Console.WriteLine($"{i + 1}. {g._goalName}");
                        i++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int record = goalList[0].GetStringToInt();
                    file._totalPoints = file._totalPoints + goalList[record - 1].RecordEvent();
                }
                else
                {
                    Console.WriteLine("Please enter a goal first.");
                }
            }
            else if (options == "6")
            {
                Console.Clear();
                Console.WriteLine("Thanks for using the program. Goodbye.");
                valid = 0;
            }
            else
            {
                Console.WriteLine("Please select 1 - 6.");
            }
        }
    }
}