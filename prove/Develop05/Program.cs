// using System;

// class Program
// {
//     static void Main(string[] args)
//     {   
//         Console.WriteLine("Menu Options:");
//         Console.WriteLine("1. Create New Goal");
//         Console.WriteLine("2. List Goals");
//         Console.WriteLine("3. Save Goals");
//         Console.WriteLine("4. Load Goals");
//         Console.WriteLine("5. Record Events");
//         Console.WriteLine("6. Quit");

//         string input = Console.ReadLine();
//         while (input != "6")
//             switch (input)
//             {
//                 case "1":
//                     // create new goal
//                     CreateNewGoal createNewGoal = new CreateNewGoal();
//                     break;
//                 case "2":
//                     // list goals
//                     ListGoal listGoals = new ListGoal();
//                     break;
//                 case "3":
//                     // save goals
//                     SaveGoals saveGoals = new SaveGoals();
//                     break;
//                 case "4":
//                     // load goals
//                     LoadGoals loadGoals = new LoadGoals();
//                     break;
//                 case "5":
//                     // record events
//                     break;
//                 case "6":
//                     // quit
//                     break;
//             }
//         Console.WriteLine("Goodbye");
//     }
// }

using System;

class Program
{
    static CreateNewGoal createNewGoal = new CreateNewGoal();
    static ListGoal listGoals = new ListGoal();
    static SaveGoals saveGoals = new SaveGoals();
    static LoadGoals loadGoals = new LoadGoals();
    static EventRecorder eventRecorder = new EventRecorder(); // Assuming an EventRecorder class

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
        {
            switch (input)
            {
                case "1":
                    createNewGoal.createNewGoal();
                    break;
                case "2":
                    listGoals.listGoal();
                    break;
                case "3":
                    saveGoals.SaveGoals();
                    break;
                case "4":
                    loadGoals.LoadGoals();
                    break;
                case "5":
                    eventRecorder.recordEvent();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    break;
            }

            Console.WriteLine(); // Add an empty line for better formatting
            Console.WriteLine("Menu Options:");
            // ... rest of the menu options
            input = Console.ReadLine();
        }

        Console.WriteLine("Goodbye");
    }
}
