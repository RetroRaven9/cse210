using System.Diagnostics;

public class Swimming: Activity
{
    private int _laps;

    public  Swimming() 
    {
        Console.WriteLine("Enter number of laps: ");
        _laps = int.Parse(Console.ReadLine());


    }
}