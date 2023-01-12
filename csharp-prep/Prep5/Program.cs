using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string name = PromptUserName();
       int number = PromptUserNumber();
       int squareOfNumber = SquareNumber(number);
       DisplayResult(name, squareOfNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);

        return number;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;

        return squareNumber;
    }
    static void DisplayResult(string name, int squareOfNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareOfNumber}");
    }
}