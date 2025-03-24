using System;

public class Resume{
    public string _clientName;
    public List<Job> _jobs = new List<Job>();

    public Resume(){}

    public void Display(){
        Console.WriteLine($"Name: {_clientName}");
        Console.WriteLine("Jobs: ");

        foreach(Job job in _jobs){
            job.Display();
        }
    }
    
}