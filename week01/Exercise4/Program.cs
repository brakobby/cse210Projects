using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int userInput = -1;
        while (userInput !=0){
            Console.WriteLine("Enter a number (0 to quit): ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0){
                numbers.Add(userInput);
            }

            
        }
        int sum = 0;
        foreach(int num in numbers){
            sum +=num;
            
        }
        Console.WriteLine($"The sum of numbers in the list is {sum}");

        float average = ((float)sum)/numbers.Count;

        Console.WriteLine($"The average of numbers in the list is {average}");
        // Finding the maximum
        int maximum_value = numbers.Max();
        Console.WriteLine($"The maximum_value of numbers in the list is {maximum_value}");
    }
}