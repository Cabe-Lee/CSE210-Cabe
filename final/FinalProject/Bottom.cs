using System;

public class Bottom : Location
{
    public Bottom()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"Death", "Push the matress"}},
            {2, new List<string> {"PickUpItem", "Befriend Goat", "Goat"}},
            {3, new List<string> {"ChangeLocation", "Climb up to the Well"}}
        };
        _description = "You slowly decend on the Bucket as the rope uncoils from the winch. You see a big pile of gold coins at the Bottom of the Well. So many forgotten wishes... You see a Matress that blocks the way further into the Well. You hear 'Baaaah' in the corner.";
        _name = "Bottom";
        _deathMessage = "You try to push the Matress but it falls on you and crushs you. Need some more topings for this Graham sandwhich?";
    }

    public override void ChangeLocation()
    {
        if (_action == 2)
        {
            _nextLocation = "Cavern";
        }
        else if (_action == 3)
        {
            _nextLocation = "Well";
        }
    }
    public override void PickUpItem(string item)
    {
        if (item == "Goat")
        {
            _options[2] = new List<string> {"ChangeLocation", "Walk through the Cavern"};
            Console.WriteLine("The black Goat pushes the heavy Matress and reveals a way through to a Cavern. The Goat begins to follow you around.");
        }
    }
}