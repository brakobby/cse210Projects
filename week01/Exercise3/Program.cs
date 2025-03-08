using System;

class Program{
    static void Main(){
        Random random = new();
        int generated_number = random.Next(1, 100);
        int attempted_time = 0;
        int guess_number = 0;
        Console.WriteLine("I'm thinking of a number between 1 and 11. Try to guess it.");  
        
        while (guess_number !=generated_number){
            Console.Write("Guess Number between 1 and 11: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out guess_number)){
                attempted_time++;
                if (guess_number < generated_number){
                    Console.WriteLine("Guess is too low");
                }else if (guess_number > generated_number){
                    Console.WriteLine("Guess is too high");
                }else{
                    Console.WriteLine($"Congratulations! you won in {attempted_time} attempts");
                }
            }else{
                Console.Write("Invalid User Input, Please enter an Integer Value");
        }

    }
}
}