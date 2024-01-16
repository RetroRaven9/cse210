using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname? ");
        //this is the line that they will input
        string firstname = Console.ReadLine();

        //reapeate the other lines for the last name
        Console.Write("What is your lastname? ");
        string lastname = Console.ReadLine();
        
        //this line will be displayed on the console with their lastname,firstname,lastname
        Console.Write($"your name is {lastname},{firstname} {lastname}.");

    }
}