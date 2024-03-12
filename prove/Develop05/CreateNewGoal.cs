// public class CreateNewGoal
// {   
//     public void createNewGoal()
//     {
//         Console.WriteLine("The type of goals are:");
//         Console.WriteLine("1. Simple Goal");
//         Console.WriteLine("2. Eternal Goal");
//         Console.WriteLine("3. Checklist Goal");

//         string input2 = Console.ReadLine();
        
//         while (input2 != "4")
//             {
//                 switch (input2)
//                 {
//                     case "1":
//                         simpleGoal simpleGoal = new simpleGoal();
//                         string simpleGoal = Console.ReadLine();
//                         int points = Console.ReadLine();
//                         break;
//                     case "2":
//                         eternalGoal eternalGoal = new eternalGoal();
//                         string eternalGoal = Console.ReadLine();
//                         int points = Console.ReadLine();
//                         break;
//                     case "3":
//                         checklistGoal checklistGoal = new checklistGoal();
//                         string checklistGoal = Console.ReadLine();
//                         int points = Console.ReadLine();
//                         break;
//                 }
//             }
//     }           

// }

public class CreateNewGoal
{
    public void createNewGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        while (choice != "4") // Assuming "4" exits the loop
        {
            switch (choice)
            {
                case "1":
                    // Get goal description and points for a Simple Goal
                    string simpleGoalDescription = GetGoalDescription("Simple Goal");
                    int simpleGoalPoints = GetGoalPoints("Simple Goal");

                    // Create a SimpleGoal object and potentially store it (implementation needed)
                    SimpleGoal simpleGoal = new SimpleGoal(simpleGoalDescription, simpleGoalPoints);
                    // ... (further logic to handle the created SimpleGoal object)

                    break;
                case "2":
                    // Get goal description and points for an Eternal Goal
                    string eternalGoalDescription = GetGoalDescription("Eternal Goal");
                    int eternalGoalPoints = GetGoalPoints("Eternal Goal");

                    // Create an EternalGoal object and potentially store it (implementation needed)
                    EternalGoal eternalGoal = new EternalGoal(eternalGoalDescription, eternalGoalPoints);
                    // ... (further logic to handle the created EternalGoal object)

                    break;
                case "3":
                    // Get goal description, points, and target count for a Checklist Goal
                    string checklistGoalDescription = GetGoalDescription("Checklist Goal");
                    int checklistGoalPoints = GetGoalPoints("Checklist Goal");
                    int checklistTargetCount = GetTargetCount();

                    // Create a ChecklistGoal object and potentially store it (implementation needed)
                    ChecklistGoal checklistGoal = new ChecklistGoal(checklistGoalDescription, checklistGoalPoints, checklistTargetCount);
                    // ... (further logic to handle the created ChecklistGoal object)

                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    break;
            }

            choice = Console.ReadLine(); // Prompt again for choice
        }
    }

    private string GetGoalDescription(string goalType)
    {
        Console.WriteLine($"Enter the description for your {goalType}:");
        return Console.ReadLine();
    }

    private int GetGoalPoints(string goalType)
    {
        Console.WriteLine($"Enter the points for your {goalType}:");
        return int.Parse(Console.ReadLine()); // Assuming valid integer input
    }

    private int GetTargetCount()
    {
        Console.WriteLine("Enter the target completion count for the checklist goal:");
        return int.Parse(Console.ReadLine()); // Assuming valid integer input
    }
}

   