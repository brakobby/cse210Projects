using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> reflectionQuestions = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult."
    };

    public ReflectionActivity(int duration) : base("Reflection", "This activity helps you reflect on significant moments in your life.", duration)
    { }

    public override void StartActivity()
    {
        base.StartActivity();
        Random random = new Random();
        string prompt = reflectionQuestions[random.Next(reflectionQuestions.Count)];

        Console.WriteLine(prompt);
        ShowAnimation();
        Thread.Sleep(5000);  // Pause for reflection

        // Asking reflective questions
        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            ShowAnimation();
            Thread.Sleep(5000);  // Pause for user response
        }

        EndActivity();
    }
}
