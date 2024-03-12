// using System.ComponentModel.DataAnnotations.Schema;

// public class RecordEvent
// {
//     bool isComplete = false;
//     public void RecordEvent()
//     {
        

//     }
// }

public class RecordEvent
{
    private List<SimpleGoal> simpleGoals;
    private List<EternalGoal> eternalGoals;
    private List<ChecklistGoal> checklistGoals;

    public RecordEvent(List<SimpleGoal> simpleGoals, List<EternalGoal> eternalGoals, List<ChecklistGoal> checklistGoals)
    {
        this.simpleGoals = simpleGoals;
        this.eternalGoals = eternalGoals;
        this.checklistGoals = checklistGoals;
    }

    public void recordEvent()
    {
        // Display a list of available goals for selection
        Console.WriteLine("Select a goal to record completion:");
        int goalIndex = 1;
        foreach (SimpleGoal goal in simpleGoals)
        {
            Console.WriteLine($"{goalIndex}. {goal.Description}");
            goalIndex++;
        }

        foreach (EternalGoal goal in eternalGoals)
        {
            Console.WriteLine($"{goalIndex}. {goal.Description}");
            goalIndex++;
        }

        foreach (ChecklistGoal goal in checklistGoals)
        {
            Console.WriteLine($"{goalIndex}. {goal.Description}");
            goalIndex++;
        }

        // Get user input for goal selection
        string choice = Console.ReadLine();
        int selectedGoalIndex;

        // Validate user input and convert to integer
        if (!int.TryParse(choice, out selectedGoalIndex) || selectedGoalIndex < 1 || selectedGoalIndex > simpleGoals.Count + eternalGoals.Count + checklistGoals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            return;
        }

        // Access the selected goal based on the index (implement logic to update goal status)
        if (selectedGoalIndex <= simpleGoals.Count)
        {
            SimpleGoal goal = simpleGoals[selectedGoalIndex - 1];
            goal.MarkComplete(); // Assuming a MarkComplete() method exists in SimpleGoal
            Console.WriteLine($"Goal '{goal.Description}' completed!");
        }
        else if (selectedGoalIndex <= simpleGoals.Count + eternalGoals.Count)
        {
            int eternalGoalIndex = selectedGoalIndex - simpleGoals.Count - 1;
            EternalGoal goal = eternalGoals[eternalGoalIndex];
            goal.MarkComplete(); // Assuming a MarkComplete() method exists in EternalGoal
            Console.WriteLine($"Goal '{goal.Description}' points awarded!");
        }
        else
        {
            int checklistGoalIndex = selectedGoalIndex - simpleGoals.Count - eternalGoals.Count - 1;
            ChecklistGoal goal = checklistGoals[checklistGoalIndex];
            goal.MarkComplete(); // Assuming a MarkComplete() method exists in ChecklistGoal
            Console.WriteLine($"Goal '{goal.Description}' completion recorded!");
        }
    }
}
