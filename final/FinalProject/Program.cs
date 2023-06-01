using System;

class Program
{
    static void Main(string[] args)
    {
        Graham graham = new Graham();
        Location currentLocation = new Location();

        graham._location = "ForkRoad";
        currentLocation = new ForkRoad();

        graham._exit = 0;
        Console.Clear();
        Console.WriteLine("You, sir Graham, are tasked on a quest by the king to retrieve the magic mirror. Once you succeed the quest, as the king's dying wish, you get to be king of the kingdom. You set on the quest. A King's Quest.");
        while (graham._exit == 0)
        {
            currentLocation = graham.Action(currentLocation);
        }
    }
}