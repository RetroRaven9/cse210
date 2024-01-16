using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        //first ask them for their name whith this line
        Console.WriteLine("What is your firstname?");
        //this is the line that will they will inpute
        string firstname = Console.ReadLine();
        //reapeate the other lines for the last name
        Console.Write("What is your lastname?");
        string lastname = Console.ReadLine();
        
        //this line will be displayed on the console with their lastname,firstname,lastname
        Console.WriteLine("your name is " + lastname + "," + firstname +" "+ lastname);


    

    
    }


}