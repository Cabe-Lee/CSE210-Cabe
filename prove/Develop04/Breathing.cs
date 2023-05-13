using System;

public class Breathing : Activity
{
    public Breathing()
    {
        _activity = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void DisplayBreathing()
    {
        Console.Write("\n\nBreath in...");
        Countdown(3);
        Console.Write("\nNow breath out...");
        Countdown(3);
    }


    
}