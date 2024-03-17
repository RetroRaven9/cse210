public class Goal{
    protected string _name;

    protected string _description;

    protected int _points;
    protected bool _check = false;

    protected int _totalPoints = 0;
    
    
    public void Goals(string name,string description,int points,bool check)
    {
        _name = name;
        _description = description;
        _points = points;
        _check = check;
        _totalPoints = _totalPoints + _points;
        

    }
}
