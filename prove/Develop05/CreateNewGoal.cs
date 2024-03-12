public class CreateNewGoal
{   
    public void createNewGoal()
    {
        Console.WriteLine("The type of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string input2 = Console.ReadLine();
        
        while (input2 != "4")
            {
                switch (input2)
                {
                    case "1":
                        simpleGoal simpleGoal = new simpleGoal();
                        string simpleGoal = Console.ReadLine();
                        int points = Console.ReadLine();
                        break;
                    case "2":
                        eternalGoal eternalGoal = new eternalGoal();
                        string eternalGoal = Console.ReadLine();
                        int points = Console.ReadLine();
                        break;
                    case "3":
                        checklistGoal checklistGoal = new checklistGoal();
                        string checklistGoal = Console.ReadLine();
                        int points = Console.ReadLine();
                        break;
                }
            }
    }           

}
   