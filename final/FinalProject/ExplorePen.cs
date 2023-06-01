using System;

public class ExplorePen : Location
{
    //      //
    public ExplorePen()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Go to Goat Pen"}},
            {2, new List<string> {"Death", "Eat a Carrot from the pile"}},
            {3, new List<string> {"PickUpItem", "Take some Carrots from the pile", "Carrot"}}
        };
        _description = "You go to the corner of the Pen and you find a pile of Carrots on the corner.";
        _name = "ExplorePen";
        _deathMessage = "You eat a juicy Carrot. The Goat notices you eating her Carrots and rams you in the fence. You get dizzy and stand up right back.";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "GoatPen";
        }
    }
    public override void PickUpItem(string item)
    {
        if (item == "Carrot")
        {
            _options[1] = new List<string> {"ChangeLocation", "Go to Goat Pen"};
            _options[2] = new List<string> {"Death", "Eat a Carrot from the pile"};
            Console.WriteLine("You put some Carrots in your pocket.");
        }
    }
}