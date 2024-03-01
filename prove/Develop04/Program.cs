using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfullness program");
        Console.WriteLine("1 is breathing");
        Console.WriteLine("2 is listing");
        Console.WriteLine("3 is reflection");
        Console.WriteLine("4 is quit");

        string input = Console.ReadLine();
        
        while (input != "4")
        {
            switch (input){
                case "1":
                    BreathingActivity b = new BreathingActivity();
                    break;
                case "2":
                    ListingActivity listing = new ListingActivity();
                    break;
                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("How are you feeling today?");
                    break;
            }
        }

        // exit message
        Console.WriteLine("Goodbye!");
    }
}