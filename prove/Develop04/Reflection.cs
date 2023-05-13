using System;

public class Reflection : Activity
{
    private List<string> _thinkList = new List<string>();
    private List<string> _reflectionList = new List<string>();
    
    public Reflection()
    {
        _activity = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _thinkList.Add("Think of a time when you stood up for someone else.");
        _thinkList.Add("Think of a time when you did something really difficult.");
        _thinkList.Add("Think of a time when you helped someone in need.");
        _thinkList.Add("Think of a time when you did something truly selfless.");
        _reflectionList.Add("Why was this experience meaningful to you?");
        _reflectionList.Add("Have you ever done anything like this before?");
        _reflectionList.Add("How did you get started?");
        _reflectionList.Add("How did you feel when it was complete?");
        _reflectionList.Add("What made this time different than other times when you were not as successful?");
        _reflectionList.Add("What is your favorite thing about this experience?");
        _reflectionList.Add("What could you learn from this experience that applies to other situations?");
        _reflectionList.Add("What did you learn about yourself through this experience?");
        _reflectionList.Add("How can you keep this experience in mind in the future?");
    }
    public void Think()
    {
        int rand = Random(_thinkList.Count - 1);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_thinkList[rand]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Pause();
        Console.WriteLine("Now ponder on each of the following questions as they related to experience.");
        Console.Write("You may begin in: ");
        Countdown(3);
    }
    public void Reflect()
    {
        Console.Clear();
        int rand = Random(_reflectionList.Count - 1);
        Console.Write($"> {_reflectionList[rand]} ");
        Spinner(5);
        Console.WriteLine("");
    }
    
}