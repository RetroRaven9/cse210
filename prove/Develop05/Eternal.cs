using System.ComponentModel;

public class Eternal:Goal
{
    public void EternalGoal(string name, string discrtiption, int points, bool check)
    {
        this._check = check;
    }

    public void isCheck(int i)
    {
        if(_check)
        {
            Console.WriteLine("The Goal has been completed");
            Console.WriteLine($"{i}[x]{_name}{_description}");
            _totalPoints = _totalPoints + _points;
        }
        else
        {
            Console.WriteLine("The Goal has not been completed");
            Console.WriteLine($"{i}[ ]{_name}{_description}");
        }
    }
}