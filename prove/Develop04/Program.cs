using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int valid = 1;
        while (valid == 1)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            string menuOptions = Console.ReadLine();

            if (menuOptions == "1")
            {
                Breathing breathing = new Breathing();
                breathing.BeginActivity();
                breathing.PromptTime();
                breathing.PrepActivity();
                
                breathing.ActivityTimer();
                while (DateTime.Now < breathing._endTime)
                {
                    breathing.DisplayBreathing();
                }
                breathing.EndPrompt();
                breathingCount++;
            }
            else if (menuOptions == "2")
            {
                Reflection reflection = new Reflection();
                reflection.BeginActivity();
                reflection.PromptTime();
                reflection.PrepActivity();
                reflection.Think();

                reflection.ActivityTimer();
                while (DateTime.Now < reflection._endTime)
                {
                    reflection.Reflect();
                }
                reflection.EndPrompt();
                reflectionCount++;
            }
            else if (menuOptions == "3")
            {
                Listing listing = new Listing();
                listing.BeginActivity();
                listing.PromptTime();
                listing.PrepActivity();
                listing.ListingPrompt();

                listing.ActivityTimer();
                while (DateTime.Now < listing._endTime)
                {
                    listing.UserPrompt();
                }
                listing.DisplayNumUserList();
                listing.EndPrompt();
                listingCount++;
            }
            else if (menuOptions == "4")
            {
                valid = 0;
                Console.Clear();
                Console.WriteLine($"You ran this many activities:");
                Console.WriteLine($"Breathing: {breathingCount}");
                Console.WriteLine($"Reflection: {reflectionCount}");
                Console.WriteLine($"Listing: {listingCount}");
                Console.WriteLine("Goodbye. :)");
            }
            else
            {
                Console.WriteLine("Please type a number between 1 - 4.");
                Thread.Sleep(3000);
            }
        }



        
    }
}