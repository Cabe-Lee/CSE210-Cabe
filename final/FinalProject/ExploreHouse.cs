using System;

public class ExploreHouse : Location
{

    public ExploreHouse()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"PickUpItem", "Pick up a Golden Egg", "GoldenEgg"}}
        };
        _description = "You hide under a chair in the kitchen and wait for the Giant to leave. He leaves and moves outside and you see a cage on the kitchen counter. You climb to the top and find a Goose with Golden Eggs around the bird.";
        _name = "ExploreHouse";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "ForkRoad";
        }
    }
    public override void PickUpItem(string item)
    {
        if (item == "GoldenEgg")
        {
            _options[1] = new List<string> {"ChangeLocation", "Go through the Portal to the Fork in the Road"};
            Console.WriteLine("You pick up a shiny, beautiful Golden Egg. And you see a magical portal to the Fork in the Road.");
        }
    }
}