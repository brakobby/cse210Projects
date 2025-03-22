using System;

class Program
{
    static void Main(string[] args)
    {
        Job newJob = new Job();
        newJob._company = "Vartsy Systems";
        newJob._jobTitle = "Data Scientist";
        newJob._jobYear = 2025;
        newJob._endYear = 2027; 

        newJob.Display(); 
    }
}