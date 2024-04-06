public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int length, double speed) : base("Cycling", date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} mph, Pace: {GetPace()} min/mile";
    }
}