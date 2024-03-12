// public class ListGoal
// {
//     public void ListGoal()
//     {
//         List<simpleGoal> goals = new List<simpleGoal>();

//         List<eternalGoal> eternalGoals = new List<eternalGoal>();

//         List<checklistGoal> checklistGoals = new List<checklistGoal>();

//     }


// }

public class ListGoal
{
    public void listGoal(List<SimpleGoal> simpleGoals, List<EternalGoal> eternalGoals, List<ChecklistGoal> checklistGoals)
    {
        if (simpleGoals.Count == 0 && eternalGoals.Count == 0 && checklistGoals.Count == 0)
        {
            Console.WriteLine("There are no goals currently.");
            return;
        }

        // Display Simple Goals
        Console.WriteLine("Simple Goals:");
        if (simpleGoals.Count > 0)
        {
            foreach (SimpleGoal goal in simpleGoals)
            {
                Console.WriteLine($"- {goal.Description} (Points: {goal.Points})");
            }
        }
        else
        {
            Console.WriteLine("  - No Simple Goals found.");
        }

        // Display Eternal Goals
        Console.WriteLine("\nEternal Goals:");
        if (eternalGoals.Count > 0)
        {
            foreach (EternalGoal goal in eternalGoals)
            {
                Console.WriteLine($"- {goal.Description} (Points: {goal.Points})");
            }
        }
        else
        {
            Console.WriteLine("  - No Eternal Goals found.");
        }

        // Display Checklist Goals
        Console.WriteLine("\nChecklist Goals:");
        if (checklistGoals.Count > 0)
        {
            foreach (ChecklistGoal goal in checklistGoals)
            {
                Console.WriteLine($"- {goal.Description} ({goal.CurrentCount}/{goal.TargetCount} completions, Points: {goal.Points})");
            }
        }
        else
        {
            Console.WriteLine("  - No Checklist Goals found.");
        }
    }
}
