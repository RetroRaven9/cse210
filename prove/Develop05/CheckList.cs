public class Checklist : Goal
{
    public void checkListGoal()
    {
        if(_check)
        {
            Console.WriteLine("The Goal has been completed.");
            
        }
        else
        {
            Console.WriteLine("The Goal has not been completed.");
        }
    }
}