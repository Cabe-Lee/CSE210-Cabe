using System;

public class Field : Location
{
    public Field()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"PickUpItem", "Grab a Pie from a nearby house window", "Pie"}},
            {2, new List<string> {"PickUpItem", "Grab a bag of Beans", "Beans"}},
            {3, new List<string> {"ChangeLocation", "Go to the Fork in the Road"}}
        };
        _description = "You're walking on the Road and find a Field next to a village. You see a bag of Beans on the ground and a nice cream Pie on the edge of a window of house.";
        _name = "Field";
        _deathMessage = "";
    }

    public override void ChangeLocation()
    {
        if (_action == 2)
        {
            _nextLocation = "Beanstalk";
        }
    }
    public override void PickUpItem(string item)
    {
        Console.WriteLine(item);
        if (item == "Pie")
        {
            // _options[1] = new List<string> {"ChangeLocation", "Go to Well"};
            Console.WriteLine("You have a nice, cream Pie.");
        }
        if (item == "Beans")
        {
            _options[2] = new List<string> {"ChangeLocation", "Plant a Bean"};
            Console.WriteLine("You put a bag of Beans in your pocket.");
        }
    }
}