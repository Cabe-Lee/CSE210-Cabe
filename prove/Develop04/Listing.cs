using System;

public class Listing : Activity
{
    private List<string> _listingList = new List<string>();
    private List<string> _userList = new List<string>();

    public Listing()
    {
        _activity = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _listingList.Add("Who are people that you appreciate?");
        _listingList.Add("What are personal strengths of yours?");
        _listingList.Add("Who are people that you have helped this week?");
        _listingList.Add("When have you felt the Holy Ghost this month?");
        _listingList.Add("Who are some of your personal heroes?");
    }
    public void ListingPrompt()
    {
        Console.WriteLine("\nList as many responses you can to the follow prompt:");
        int rand = Random(_listingList.Count - 1);
        Console.WriteLine($" --- {_listingList[rand]} ---");
        Console.Write("You may begin in: ");
        Countdown(3);
        Console.WriteLine("");
    }
    public void UserPrompt()
    {
        Console.Write("> ");
        _userList.Add(Console.ReadLine());
    }
    public void DisplayNumUserList()
    {
        Console.Write($"You listed {_userList.Count} items!");
    }


    
}