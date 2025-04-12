using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Choose activity type
        Console.WriteLine("Choose an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        int choice = int.Parse(Console.ReadLine());

        // Set duration for activity
        Console.WriteLine("Enter the duration in seconds for the activity: ");
        int duration = int.Parse(Console.ReadLine());

        // Create and start the selected activity
        MindfulnessActivity activity = null;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        // Start activity
        activity.StartActivity();
    }
}
