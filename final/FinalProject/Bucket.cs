using System;

public class Bucket : Items
{
    public Bucket()
    {
        _name = "Bucket";
        _description = "A Bucket of water";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        if (locationName == "Well")
        {
            Console.WriteLine("You tie the Bucket to the rope of the Well.");
            nextLocation = "Bottom";
        }
        else
        {
            Console.WriteLine("You splashed water on yourself.");
        }
        return nextLocation;
    }
}