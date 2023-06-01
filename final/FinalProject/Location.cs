using System;

public class Location
{
    public string _name;
    public string _description;
    public Dictionary<int, List<string>> _options { get; set; }
    public int _action;
    public string _nextLocation;
    public string _deathMessage;

    public Location()
    {

    }

    public void DisplayLocation()
    {
        Console.WriteLine($"{_name}: {_description}");
    }
    public virtual void ChangeLocation()
    {

    }
    public virtual void PickUpItem(string item)
    {
        
    }
    public string UseItem(Items item)
    {
        string action = "UseItem";
        _nextLocation = item.Trigger(_name);
        if (_name != _nextLocation)
        {
            action = "ChangeLocation";
        }
        return action;
    }
}