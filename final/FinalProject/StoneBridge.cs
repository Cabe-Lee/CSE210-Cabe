using System;

public class StoneBridge : Location
{
    public StoneBridge()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Leave to the Grassy Hill"}},
            {2, new List<string> {"Death", "Cross the Bridge"}},
        };
        _description = "You arrive at a Stone Bridge.";
        _name = "StoneBridge";
        _deathMessage = "As you cross the bridge, you see an ogre get smacked and flatten by his club. Graham club sandwhich, anyone?";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "GrassyHill";
        }
    }
}