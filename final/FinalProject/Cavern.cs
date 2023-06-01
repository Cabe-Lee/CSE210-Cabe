using System;

public class Cavern : Location
{
    public Cavern()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"Death", "Fight the Dragon"}},
            {2, new List<string> {"ChangeLocation", "Run from the Dragon"}},
        };
        _description = "You walk deeper into the Cavern and you see beds wrapped around cave spikes above and moving from the wind. You hear a crack of bones from your feet. the wind stops. You see a huge scaled dragon coming about to come throuogh the small hole on the other side. One of the beds falls with pillows and blankets.";
        _name = "Cavern";
        _deathMessage = "The Dragon breaths fire and burns you to ash... Smores anyone?";
    }

    public override void ChangeLocation()
    {
        if (_action == 2)
        {
            _nextLocation = "Bottom";
        }
        
    }
    public override void PickUpItem(string item)
    {
        
    }
}