
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity
{
    private static readonly Random Random = new Random(); // Create single random instance

    private static string[] Prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public static void Run()
    {
        // Standard starting message
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life.");

        // Get duration from user
        int duration = GetDurationInput();

        // Display random prompt and countdown
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("\nStarting in...");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Wait for 1 second
        }

        // Start listing items and capture user input
        List<string> listedItems = new List<string>();
        Console.WriteLine("Begin listing:");
        DateTime startTime = DateTime.Now;
        while (DateTime.Now.Subtract(startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item)) // Check if input is empty or whitespace
            {
                listedItems.Add(item);
            }
        }

        // Display results
        Console.WriteLine($"\nYou listed {listedItems.Count} items.");

        // Standard finishing message
        Console.WriteLine("Thank you for using the Listing Activity!");
    }

    private static int GetDurationInput()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter the duration in seconds: ");
                string input = Console.ReadLine();
                int duration = int.Parse(input);
                if (duration > 0)
                {
                    return duration;
                }
                else
                {
                    Console.WriteLine("Duration must be positive. Please try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }

    private static string GetRandomPrompt()
    {
        int index = Random.Next(Prompts.Length); // Generate random index
        return Prompts[index];
    }
}
