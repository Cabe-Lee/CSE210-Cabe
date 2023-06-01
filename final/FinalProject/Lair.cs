using System;

public class Lair : Location
{
    //      //
    public Lair()
    {
        _options = new Dictionary<int, List<string>>
        {
            
        };
        _description = "You find a wonderous golden Magic Mirror and a massive treasure trove of Gold coins, emeralds, rubies, and sparkling diamonds. A treasure fit for a King! THE END. \nWritten by: Cabe Lee";
        _name = "Lair";
        _deathMessage = "You die a really wealthy man!";
    }


    //      //
    public override void ChangeLocation()
    {

    }
    public override void PickUpItem(string item)
    {
        
    }
}