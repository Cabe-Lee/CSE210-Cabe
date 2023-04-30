using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        int valid = 1;
        while (valid == 1)
        {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string number = Console.ReadLine();

            if (number == "1")
            {
                Entry entry = new Entry();
                entry.GetRandomPrompt();
                entry.GetDate();
                journal.AddEntry(entry._datetime, entry._promptUser, entry._resoponseUser);
            }
            else if (number == "2")
            {
                journal.DisplayEntry();
            }
            else if (number == "3")
            {
                journal.LoadFile();
            }
            else if (number == "4")
            {
                journal.SaveJournal();
            }
            else if (number == "5")
            {
                valid = 0;
            }
            else
            {
                
            }
        }
    }
}