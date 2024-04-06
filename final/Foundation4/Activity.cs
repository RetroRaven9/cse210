public class Activity
{
    protected string _name;
    protected DateTime _date;
    protected int _length; // in minutes

    public Activity(string name, DateTime date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        // Default implementation for activities without distance calculation
        return 0;
    }

    public virtual double GetSpeed()
    {
        // Default implementation for activities without speed calculation
        return 0;
    }

    public virtual double GetPace()
    {
        // Default implementation for activities without pace calculation
        return 0;
    }

    public virtual string GetSummary()
    {
        // Default implementation for summary
        return $"{_date.ToString("dd MMM yyyy")} {_name} ({_length} min)";
    }
}
    