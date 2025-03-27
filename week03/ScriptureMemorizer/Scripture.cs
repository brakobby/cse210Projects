using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{_reference}: {string.Join(" ", _words)}\n");
    }

    public bool HideWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.Hidden).ToList();
        if (visibleWords.Count == 0)
            return false;

        var random = new Random();
        foreach (var word in visibleWords.OrderBy(x => random.Next()).Take(count))
        {
            word.Hide();
        }

        return true;
    }
}
