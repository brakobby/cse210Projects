using System;

class Program
{   
   static void DisplayWelcome(){
    Console.Write("Welcome to the Program");
   }

   static string PromptUserName(){
    Console.Write("What is your name? ");
    string name = Console.ReadLine();
    return name;
   }

   static int PromptUserNumber(){
    Console.Write("Please enter your favorite number: ");
    string favoriteNumber = Console.ReadLine();
    int favNumber = int.Parse(favoriteNumber); 
    return favNumber;

   }
   static int SquareNumber(int num){
    return num*num;
   }

   static void DisplayResult(string name, int squareNumber){
    Console.WriteLine($"{name}, the square of your favorite number is {squareNumber}");
   }

   static void Main(String[] args){
    DisplayWelcome();
    string username = PromptUserName();
    int favoriteNumber = PromptUserNumber();
    int squareNumber = SquareNumber(favoriteNumber);
    DisplayResult(username,squareNumber);
   }
}