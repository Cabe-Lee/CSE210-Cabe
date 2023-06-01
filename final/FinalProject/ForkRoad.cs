using System;

public class ForkRoad : Location
{
    public ForkRoad()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Left path"}},
            {2, new List<string> {"ChangeLocation", "Middle path"}},
            {3, new List<string> {"ChangeLocation", "Right path"}}
        };
        _description = "You walk up to a Fork in the Road.";
        _name = "Crossroads";
    }
    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "Gingerbread";
        }
        else if (_action == 2)
        {
            _nextLocation = "GrassyHill";
        }
        else if (_action == 3)
        {
            _nextLocation = "Field";
        }
    }
}