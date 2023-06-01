using System;

public class GrassyHill : Location
{
    public GrassyHill()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Go to the Stone Bridge"}},
            {2, new List<string> {"ChangeLocation", "Go to a Goat Pen"}},
            {3, new List<string> {"ChangeLocation", "Go to the Fork in the Road"}}
        };
        _description = "You walk up a Grassy Hill and find a Stone bridge on the left, while you see a Goat Pen on the right.";
        _name = "GrassyHill";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "StoneBridge";
        }
        else if (_action == 2)
        {
            _nextLocation = "GoatPen";
        }
        else if (_action == 3)
        {
            _nextLocation = "ForkRoad";
        }
    }
    public override void PickUpItem(string item)
    {

    }
}
    
