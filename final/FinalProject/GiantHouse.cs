using System;

public class GiantHouse : Location
{
    public GiantHouse()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Hide from the Giant"}},
            {2, new List<string> {"Death", "Fight the Giant"}},
        };
        _description = "You sneak into the Giant's House. As you enter the House, you hear stomps coming toward the House.";
        _name = "GiantHouse";
        _deathMessage = "You try to fight him, but get stomped by the Giant. Graham waffles... Need some syrup and whipped cream?";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "ExploreHouse";
        }
    }
    public override void PickUpItem(string item)
    {
        
    }
}