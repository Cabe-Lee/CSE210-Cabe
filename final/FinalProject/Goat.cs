using System;

public class Goat : Items
{
    public Goat()
    {
        _name = "Goat";
        _description = "A friendly, strong black Goat";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        Console.WriteLine("The Goat gives you a raised brow.");
        return nextLocation;
    }
}