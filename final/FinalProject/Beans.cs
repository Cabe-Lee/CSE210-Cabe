using System;

public class Beans : Items
{
    public Beans()
    {
        _name = "Beans";
        _description = "A bag of Beans";
    }
    public override string Trigger(string locationName)
    {
        string nextLocation = locationName;
        if (locationName == "Field")
        {
            Console.WriteLine("You plant a Bean and it grows to a giant beanstalk.");
            nextLocation = "Beanstalk";
        }
        else
        {
            Console.WriteLine("You shake the bag.");
        }
        return nextLocation;
    }
}