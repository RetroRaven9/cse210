// public class LoadGoals
// {
//     public void LoadGoals()
//     {
        
//     }

// }

public class LoadGoals
{
    public void LoadGoals(List<SimpleGoal> simpleGoals, List<EternalGoal> eternalGoals, List<ChecklistGoal> checklistGoals)
    {
        // Implement error handling for file operations (e.g., using try-catch block)
        string filePath = @"C:\Users\tylar\OneDrive\Desktop\classes\cse210\prove\Develop05\savedgoals.txt"; // Assuming the file path

        // Open the file for reading
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Parse the loaded line and convert it back to the corresponding goal object (implement logic)
                // Based on the parsing, add the goal object to the appropriate list (simpleGoals, eternalGoals, checklistGoals)
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}


