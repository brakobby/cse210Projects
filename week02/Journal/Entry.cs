using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Save the date
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("---------------------------");
    }

    public override string ToString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
