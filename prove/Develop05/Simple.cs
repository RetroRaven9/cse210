using System.Security.Cryptography.X509Certificates;

public class Simple:Goal
{
    

    public void simpleGoals(string name, string description, int points, bool check)

    {
        this._check = check;
        

    }
    public void isCheck(int i)
    {
        if (_check)
        {
            Console.WriteLine("The Goal has been completed");
            Console.WriteLine($"{i}[x]{_name}{_description}");

            Console.WriteLine($"{_points}");
        }
        else
        {
            Console.WriteLine("The Goal has not been completed");
            Console.WriteLine($"{i}[ ]{_name}{_description}");
        }
    }
}