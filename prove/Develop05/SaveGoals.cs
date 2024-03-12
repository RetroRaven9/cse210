// public class SaveGoals
// {   
//     public void savedgoals()
//     { 
//     string savedgoals = @"C:\Users\tylar\OneDrive\Desktop\classes\cse210\prove\Develop05\savedgoals.txt";
//     Savedgoals savedgoals = new Savedgoals();
//     }
// }

public class SaveGoals
{
    public void SaveGoals(List<SimpleGoal> simpleGoals, List<EternalGoal> eternalGoals, List<ChecklistGoal> checklistGoals)
    {
        // Implement error handling for file operations (e.g., using try-catch block)
        string filePath = @"C:\Users\tylar\OneDrive\Desktop\classes\cse210\prove\Develop05\savedgoals.txt"; // Assuming the file path

        // Open the file for writing (replace/append based on desired behavior)
        using (StreamWriter writer = new StreamWriter(filePath, false)) // Open in "false" mode to overwrite
        {
            // Write data for each goal type (implement logic to convert goal objects to a suitable format for saving)
            foreach (SimpleGoal goal in simpleGoals)
            {
                writer.WriteLine(goal.ToString()); // Assuming a ToString() method exists in SimpleGoal to format data
            }

            foreach (EternalGoal goal in eternalGoals)
            {
                writer.WriteLine(goal.ToString()); // Similar approach for EternalGoal
            }

            foreach (ChecklistGoal goal in checklistGoals)
            {
                writer.WriteLine(goal.ToString()); // Similar approach for ChecklistGoal
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
}
