using System;

public class Beanstalk : Location
{
    public Beanstalk()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"ChangeLocation", "Run from the Giant"}},
            {2, new List<string> {"Death", "Fight the Giant"}},
        };
        _description = "You climb the Beanstalk all the way to the top and find youself in a cloud like area you can walk on. You suddenly see a Giant stomping towards you.";
        _name = "Beanstalk";
        _deathMessage = "You try to fight him, but get stomped by the Giant. Graham pancakes... Need some syrup?";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "Field";
        }
    }
    public override void PickUpItem(string item)
    {
        
    }
}