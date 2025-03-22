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

    static void Main(string[] args)
    {
        Job newJob = new Job();
        newJob._company = "Vartsy Systems";
        newJob._jobTitle = "Data Scientist";
        newJob._jobYear = 2025;
        newJob._endYear = 2027; // Fixed the incorrect assignment

        newJob.Display(); // Added to print job details
    }
}