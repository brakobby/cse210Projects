using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _jobYear;
    public int _endYear;

    public Job() { }

    public void Display()
    {
        Console.WriteLine($"{_company}");
        Console.WriteLine($"{_jobTitle}");
        Console.WriteLine($"{_jobYear}");
        Console.WriteLine($"{_endYear}");
    }
}