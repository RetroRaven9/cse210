using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your class score?");
        string score = Console.ReadLine();
        
        int grade = int.Parse(score);
        
        if(grade >= 90)
        {
            Console.WriteLine("A");
        }

        else if(grade >= 80)
        {
            Console.WriteLine("B");
        }

        else if(grade >= 70)
        {
            Console.WriteLine("C");
        }   

        else if(grade < 60)
        {
            Console.WriteLine("D");
        }
    
        
    
    
    
    }

}