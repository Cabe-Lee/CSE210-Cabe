using System;

public class Candy : Items
{
    public Candy()
    {
        _name = "Candy";
        _description = "A bunch of Candy";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        Console.WriteLine("You eat some candy.");
        return nextLocation;
    }
}