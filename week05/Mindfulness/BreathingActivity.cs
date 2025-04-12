using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will guide you through breathing in and out slowly.", duration)
    { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Let's begin...");

        // Breathing activity: inhale and exhale
        for (int i = 0; i < _duration / 5; i++)  
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation();
            Thread.Sleep(3000);  // 3 seconds for inhale

            Console.WriteLine("Breathe out...");
            ShowAnimation();
            Thread.Sleep(3000);  // 3 seconds for exhale
        }

        EndActivity();
    }
}
