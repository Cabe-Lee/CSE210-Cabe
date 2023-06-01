using System;

public class GoatPen : Location
{
    public GoatPen()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"Death", "Pet Goat"}},
            {2, new List<string> {"ChangeLocation", "Explore Pen"}},
            {3, new List<string> {"ChangeLocation", "Leave to the Grassy Hill"}}
        };
        _description = "You walk into a Goat Pen with a white Goat walking around minding it's own buisness.";
        _name = "GoatPen";
        _deathMessage = "Goat kicks and sends you flying to the gate of the pen. You get dizzy and stand up right back.";
    }

    public override void ChangeLocation()
    {
        if (_action == 2)
        {
            _nextLocation = "ExplorePen";
        }
        else if (_action == 3)
        {
            _nextLocation = "GrassyHill";
        }
    }
    public override void PickUpItem(string item)
    {
        // if (item == "Carrot")
        // {
        //     _options[1] = new List<string> {"PickUpItem", "Feed Goat", "Goat"};
        //     Console.WriteLine("You give a Carrot to the Goat. He follows you around.");
        // }
        // if (item == "Goat")
        // {
        //     _options[1] = new List<string> {"ChangeLocation", "Go to Stone Bridge"};
        //     Console.WriteLine("You have arrived to the Bridge.");
        // }
    }
}