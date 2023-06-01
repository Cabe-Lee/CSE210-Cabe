using System;

public class Pie : Items
{
    public Pie()
    {
        _name = "Pie";
        _description = "A cream Pie";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        if (locationName == "Beanstalk")
        {
            Console.WriteLine("You give the Giant a pie. He likes the pie and falls asleep.");
            nextLocation = "GiantHouse";
        }
        else
        {
            Console.WriteLine("Mmmmm... Yummy, love the cream.");
        }
        return nextLocation;
    }
}