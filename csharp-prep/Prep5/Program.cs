using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your Name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorit number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }
    
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number in {square}");
        }
    
    }

}