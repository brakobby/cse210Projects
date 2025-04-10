using System;

public class Comment
{
    public string Name { get; private set; }
    public string Text { get; private set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {Name}: {Text}");
    }
}
