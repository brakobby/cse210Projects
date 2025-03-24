using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private static List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added successfully!\n");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            _entries.Add(Entry.FromString(line));
        }

        Console.WriteLine("Journal loaded successfully!\n");
    }
}
