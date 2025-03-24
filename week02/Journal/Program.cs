using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("===== Journal Menu =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    myJournal.SaveToFile();
                    break;
                case "4":
                    myJournal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }
}
