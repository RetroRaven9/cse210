using System;
//using System.Collections;
//using System.Diagnostics;
using System.IO;
class Program
{
    private static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string userChoice = "1";
        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal");
            Console.WriteLine("Please select a one of the following choices");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");

            userChoice = Console.ReadLine();
           
            switch (userChoice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();


                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;
                    
                    break;
                case "2":
                    Console.WriteLine("Display");
                    foreach (Entry singleEntry in myJournal.entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} {singleEntry._response}");
                    }
                    break;
                case "3":
                     string fileSave = "journal.txt";
                    string[] lines = System.IO.File.ReadAllLines(fileSave);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        
                    }
                    break;
                case "4":
                    string fileLoad = "journal.txt";
                    using (StreamWriter outputFile = new StreamWriter(fileLoad))
                    {
                        outputFile.WriteLine();
                    }

                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}