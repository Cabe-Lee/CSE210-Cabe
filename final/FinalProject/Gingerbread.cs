using System;

public class Gingerbread : Location
{
    public Gingerbread()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"Death", "Eat door"}},
            {2, new List<string> {"ChangeLocation", "Knock door"}},
            {3, new List<string> {"ChangeLocation", "Go to the Fork in the Road"}}
        };
        _description = "You discover a large Gingerbread house in the middle of the forest.";
        _name = "Gingerbread";
        _deathMessage = "You fall into eternal sleep. It's no time to take nap, Graham.";
    }
    public override void ChangeLocation()
    {
        if (_action == 2)
        {
            _nextLocation = "House";
        }
        else if (_action == 3)
        {
            _nextLocation = "ForkRoad";
        }
    }
}
