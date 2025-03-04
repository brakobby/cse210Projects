using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Marks Scored: ");
        string markScored = Console.ReadLine();

        int markScored_value;
        if (!int.TryParse(markScored, out markScored_value))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        string letter = "";
        string sign = "";

        if (markScored_value >= 90)
        {
            letter = "A";
        }
        else if (markScored_value >= 80)
        {
            letter = "B";
        }
        else if (markScored_value >= 70)
        {
            letter = "C";
        }
        else if (markScored_value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = markScored_value % 10;
        
        if (letter != "A" && letter != "F") 
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Grade: {letter}{sign}");
        
        if (markScored_value >= 70)
        {
            Console.WriteLine("Remarks: You have passed successfully. Congratulations!");
        }
        else
        {
            Console.WriteLine("Remarks: You can do better! Keep trying.");
        }
    }
}
