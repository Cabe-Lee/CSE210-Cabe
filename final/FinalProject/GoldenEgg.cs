using System;

public class GoldenEgg : Items
{
    public GoldenEgg()
    {
        _name = "GoldenEgg";
        _description = "A shiny Golden Egg";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        if (locationName == "Cavern")
        {
            Console.WriteLine("You throw the Golden Egg to distract the Dragon. The Dragon swallows the egg whole. And begins to choke and eventually dies.");
            nextLocation = "Lair";
        }
        else
        {
            Console.WriteLine("You toss the Golden Egg around.");
        }
        return nextLocation;
    }
}