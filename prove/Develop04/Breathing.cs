using System;
using System.Threading;

public class BreathingActivity : Mindfulness
{
    public void Run()
    {Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("How long would you like to do this activity in seconds?");

        int duration = int.Parse(Console.ReadLine());

        // Set inhale and exhale durations (adjust according to preference)
        int inhaleDuration = 4;
        int exhaleDuration = 6;

        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000); // Wait for 2 seconds before starting

        while (duration > 0)
        {
            // Inhale prompt
            Console.WriteLine($"Breathe in for {inhaleDuration} seconds...");
            StartTimer(inhaleDuration);

            // Exhale prompt
            Console.WriteLine($"Breathe out for {exhaleDuration} seconds...");
            StartTimer(exhaleDuration);

            duration -= (inhaleDuration + exhaleDuration); // Decrement remaining duration
        }

        Console.WriteLine("Thank you for using the Breathing Activity!");
    }

    private void StartTimer(int seconds)
    {
        

        using (var timer = new System.Timers.Timer(seconds * 1000)) // Convert seconds to milliseconds
        {
            timer.Elapsed += delegate { Console.WriteLine("Time's up!"); };
            timer.Start();
            Thread.Sleep(seconds * 1000); // Wait for timer to complete
        }
    }
}

