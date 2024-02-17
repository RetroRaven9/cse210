using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            scripture.HideRandomWord();
            Console.WriteLine(scripture.GetVisibleText());
        }
    }
}