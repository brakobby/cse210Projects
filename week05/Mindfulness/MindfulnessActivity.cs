using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    // Constructor
    public MindfulnessActivity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    // Start activity
    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} activity...");
        Console.WriteLine(_description);
        ShowAnimation();
    }

    // End activity
    public virtual void EndActivity()
    {
        Console.WriteLine($"Ending {_activityName} activity...");
    }

    // Show an animation (progress spinner)
    public void ShowAnimation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}
