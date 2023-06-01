using System;

public class House : Location
{
    public House()
    {
        _options = new Dictionary<int, List<string>>
        {
            {1, new List<string> {"PickUpItem", "Grab a water Bucket", "Bucket"}},
            {2, new List<string> {"PickUpItem", "Take a pile of Candy", "Candy"}},
            {3, new List<string> {"Death", "Open the cage door"}}
        };
        _description = "You knock on the door, the door opens and a witch greets you. She wants to have you for dinner. She casts a spell to have you fall asleep. You find yourself in a cage with a Bucket of water and a pile of Candy next to a boiling pot.";
        _name = "House";
        _deathMessage = "The door creaks loudly, the witch grabs you and throws you in the pot. Mmmm... Graham soup.";
    }

    public override void ChangeLocation()
    {
        if (_action == 1)
        {
            _nextLocation = "Field";
        }
        else if (_action == 2)
        {
            _nextLocation = "ForkRoad";
        }
    }
    public override void PickUpItem(string item)
    {
        Console.WriteLine(item);
        if (item == "Bucket")
        {
            _options[1] = new List<string> {"ChangeLocation", "Quietly sneak out of the cage and walk to the Field"};
            Console.WriteLine("You grab the Bucket and splash water on the witch. She slips, falls, and is knocked unconscious.");
            Console.WriteLine("You keep the Bucket");
        }
        if (item == "Candy")
        {
            _options[2] = new List<string> {"ChangeLocation", "Bolt out of the cage and run to the Fork in the Road."};
            Console.WriteLine("You throw some Candy near the witch. She eats the Candy and falls a sleep.");
            Console.WriteLine("You put the Candy in your pocket.");
        }
    }
}