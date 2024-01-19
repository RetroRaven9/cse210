using System;

class Program
{
    static void Main(string[] args)
    

    {
        
        Console.WriteLine("Welcome to the random number game please guess a number from 1-100 ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess;

        do
        {   
            Console.WriteLine("What is your guess?");
            string userGuessString = Console.ReadLine();
        
            if(int.TryParse(userGuessString, out userGuess))
            {
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Congratulations! You Won!");
                }
            }
            else
            {
                Console.WriteLine("Invalid guess");
            }
            
            

        }while (userGuess != magicNumber);
    }
}