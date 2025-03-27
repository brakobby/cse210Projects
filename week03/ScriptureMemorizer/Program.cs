using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        // Allowing user to select a scripture reference from predefined options
        var scriptures = new Dictionary<int, (Reference, string)>
        {
            { 1, (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.") },
            { 2, (new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.") }
        };

        Console.WriteLine("Choose a scripture to memorize:");
        foreach (var entry in scriptures)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value.Item1}");
        }

        Console.Write("Enter choice: ");
        int choice = int.TryParse(Console.ReadLine(), out int selected) && scriptures.ContainsKey(selected) ? selected : 1;

        var scripture = new Scripture(scriptures[choice].Item1, scriptures[choice].Item2);

        while (true)
        {
            scripture.Display();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            var input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
                break;

            if (!scripture.HideWords())
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                Thread.Sleep(3000);
                break;
            }
        }
    }
}
