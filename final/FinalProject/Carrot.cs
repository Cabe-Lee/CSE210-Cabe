using System;

public class Carrot : Items
{
    public Carrot()
    {
        _name = "Carrot";
        _description = "A tasty Carrot";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        if (locationName == "GoatPen")
        {
            Console.WriteLine("You feed the Carrot to the Goat and befriend her. She leads past the bridge to a Well. She points at the Well, turns, and leaves. You hear a 'Baaaah' in the Well.");
            nextLocation = "Well";
        }
        else
        {
            Console.WriteLine("You wave the Carrot around.");
        }
        return nextLocation;
    }
}