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

        Job newJob2 = new Job();
        newJob2._company = "Apple";
        newJob2._jobTitle = "AI Specialist";
        newJob2._jobYear = 2025;
        newJob2._endYear = 2026; 
        newJob2.Display();


        
    }
}