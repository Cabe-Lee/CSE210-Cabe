using System;

public class Items
{
    public string _name;
    public string _description;

    public Items()
    {

    }
    public virtual string Trigger(string locationName)
    {
        return "";
    }
}