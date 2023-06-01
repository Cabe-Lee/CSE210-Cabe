using System;

public class Well : Location
{
    public Well()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Go to the Goat Pen"}},
            {2, new List<string> {"Death", "Jump in the Well"}}
        };
        _description = "You see a Well in a dark forest. At the top of the Well, there is winch for a rope with no Bucket.";
        _name = "Well";
        _deathMessage = "You jump in the in Well and fall in the hard pile of gold coins, breaking your neck. Well... That didn't work.";
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

    }
}