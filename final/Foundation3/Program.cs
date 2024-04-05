using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public string _choice;
    static void Main(string[] args)
    {
        Console.WriteLine("1. Lecture /n 2. Receptions /n 3. Outdoor");
        _choice = Console.ReadLine();
        switch (_choice)
        case ("1"):
            //do something
            break;
        case ("2"):
            //do something
            break;
        case ("3"):
            //do something
            break;
        default:
            //do something
            break;
    }
}