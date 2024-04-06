using System.Data.Common;

public class Running : Activity
{
    public Running(string name, int length, double distance) : base(name, length, distance)
    {
        Console.WriteLine("how long did you run?");
        Console.ReadLine();
    }
   
}
