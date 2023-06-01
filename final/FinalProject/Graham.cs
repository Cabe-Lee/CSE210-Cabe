using System;

public class Graham
{
    public string _location;
    public List<string> _items { get; set; }
    public int _exit;
    public string _currentItem;


    //      //
    public Graham()
    {
        _items = new List<string>();
        _items.Add(""); 
    }

    //      //
    public Location Action(Location currentLocation)
    {
        currentLocation.DisplayLocation();
        string action = GetOption(currentLocation);
        if (action == "UseItem")
        {
            action = UseItem(currentLocation);
            // Console.WriteLine($"{action} {currentLocation._nextLocation}");
        }
        if (action == "ChangeLocation")
        {
            currentLocation.ChangeLocation();
            currentLocation = ChangeLocation(currentLocation._nextLocation);
        }
        else if (action == "PickUpItem")
        {
            PickUpItem(currentLocation);
        }
        else if (action == "Death")
        {
            Death(currentLocation);
        }
        else if (action == "UseItem")
        {

        }
        else if (action == "Exit")
        {
            _exit = 1;
            Console.WriteLine("Goodbye.");
        }
        return currentLocation;
    }
    public string GetOption(Location currentLocation)
    {
        string action = "";
        int exit = 0;
        int useItemValid = 0;
        int numOptions = 0;
        int i = 1;
        foreach (KeyValuePair<int, List<string>> opt in currentLocation._options)
        {
            Console.WriteLine($"{opt.Key}. {opt.Value[1]}.");
            numOptions = i;
            i++;
        }
        if (_items.Count > 1)
        {
            Console.WriteLine($"{i}. Use Item?");
            useItemValid = i;
            i++;        
        }
        exit = i;
        Console.WriteLine($"{i}. Quit the game?");
        Console.WriteLine("");
        string option = Console.ReadLine();
        int num = int.Parse(option);
        if (num <= numOptions)
        {
            List<string> actions = currentLocation._options[num];
            currentLocation._action = num;
            action = actions[0];
            if (action == "PickUpItem")
            {
                _currentItem = actions[2];
            }
        }
        else if (useItemValid > 0)
        {
            action = "UseItem";
        }
        if (num == exit)
        {
            action = "Exit";
        }

        return action;
    }
    public Location ChangeLocation(string nextLocation)
    {
        _location = nextLocation;
        Location newLocation = new Location();
        if (nextLocation == "Gingerbread")
        {
            newLocation = new Gingerbread();
        }
        else if (nextLocation == "House")
        {
            newLocation = new House();
        }
        else if (nextLocation == "GrassyHill")
        {
            newLocation = new GrassyHill();
        }
        else if (nextLocation == "StoneBridge")
        {
            newLocation = new StoneBridge();
        }
        else if (nextLocation == "GoatPen")
        {
            newLocation = new GoatPen();
        }
        else if (nextLocation == "ExplorePen")
        {
            newLocation = new ExplorePen();
        }
        else if (nextLocation == "Field")
        {
            newLocation = new Field();
        }
        else if (nextLocation == "Beanstalk")
        {
            newLocation = new Beanstalk();
        }
        else if (nextLocation == "GiantHouse")
        {
            newLocation = new GiantHouse();
        }
        else if (nextLocation == "ExploreHouse")
        {
            newLocation = new ExploreHouse();
        }
        else if (nextLocation == "Well")
        {
            newLocation = new Well();
        }
        else if (nextLocation == "Bottom")
        {
            newLocation = new Bottom();
        }
        else if (nextLocation == "Cavern")
        {
            newLocation = new Cavern();
        }
        else if (nextLocation == "Lair")
        {
            newLocation = new Lair();
        }
        else
        {
            newLocation = new ForkRoad();
            _location = "ForkRoad";
        }

        return newLocation;
    }
    public void PickUpItem(Location currentLocation)
    {
        _items.Add(_currentItem);
        currentLocation.PickUpItem(_currentItem);
    }
    public string UseItem(Location currentLocation)
    {
        string action = "UseItem";
        int i = 0;
        List<Items> genItem = new List<Items>();
        Console.WriteLine("Which item would you like to use?");
        foreach (string item in _items)
        {
            if (item == "Bucket")
            {
                genItem.Add(new Bucket());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "Candy")
            {
                genItem.Add(new Candy());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "Carrot")
            {
                genItem.Add(new Carrot());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "Goat")
            {
                genItem.Add(new Goat());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "Beans")
            {
                genItem.Add(new Beans());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "GoldenEgg")
            {
                genItem.Add(new GoldenEgg());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
            if (item == "Pie")
            {
                genItem.Add(new Pie());
                Console.WriteLine($"{i + 1}. {genItem[i]._name}, {genItem[i]._description}");
                i++;
            }
        }
        string selectItem = Console.ReadLine();
        int numItem = int.Parse(selectItem) - 1;
        string newAction = currentLocation.UseItem(genItem[numItem]);
        if (newAction != "")
        {
            action = newAction;
        }
        return action;
    }
    public void Death(Location currentLocation)
    {
        Console.Clear();
        Console.WriteLine(currentLocation._deathMessage);
    }
}