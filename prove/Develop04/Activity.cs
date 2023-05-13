using System;

public class Activity
{
    private string _startMsg;
    private string _endMsg;
    protected string _activity;
    protected string _description;
    protected int _activityTime;
    public DateTime _endTime;

    public Activity()
    {
        
    }
    public void BeginActivity()
    {
        Console.Clear();
        _startMsg = $"Welcome to the {_activity} Activity.";
        Console.WriteLine($"{_startMsg}\n");
        Console.WriteLine($"{_description}\n");
    }
    public void PromptTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityTime = Int32.Parse(Console.ReadLine());
    }
    public void PrepActivity()
    {
        Console.Clear();
        Console.Write("Get ready...");
        Spinner(3);
    }
    private DateTime Timer(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime returnTime = startTime.AddSeconds(time);
        return returnTime;
    }
    public void ActivityTimer()
    {
        _endTime = Timer(_activityTime);
    }
    public void Countdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinner(int time)
    {
        // |/-\|/-\|Spinner Animation
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        
        DateTime endTime = Timer(time);
        while (DateTime.Now < endTime)
        {
            foreach (string a in animation)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void Pause()
    {
        Console.ReadLine();
    }
    public void EndPrompt()
    {
        Console.WriteLine("\n\nWell done!!\n");
        _endMsg = $"You have completed another {_activityTime} seconds of the {_activity} Activity.";
        Console.WriteLine($"{_endMsg}");
        Spinner(3);
        Console.Clear();
    }
    public int Random(int size)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, size);
        return number;
    }
}