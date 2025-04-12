using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int duration) : base("Listing", "This activity helps you list the things you're grateful for or reflective about.", duration)
    { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Start listing your thoughts or things you are grateful for.");
        ShowAnimation();
        Thread.Sleep(5000);  // Give user time to think

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items (type 'done' when you're finished):");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;

            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}
