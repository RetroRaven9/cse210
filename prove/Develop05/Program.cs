using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Events");
        Console.WriteLine("6. Quit");

        string input = Console.ReadLine();
        while (input != "6")
            switch (input)
            {
                case "1":
                    // create new goal
                    CreateNewGoal createNewGoal = new CreateNewGoal();
                    break;
                case "2":
                    // list goals
                    ListGoal listGoals = new ListGoal();
                    break;
                case "3":
                    // save goals
                    SaveGoals saveGoals = new SaveGoals();
                    break;
                case "4":
                    // load goals
                    LoadGoals loadGoals = new LoadGoals();
                    break;
                case "5":
                    // record events
                    break;
                case "6":
                    // quit
                    break;
            }
        Console.WriteLine("Goodbye");
    }
}