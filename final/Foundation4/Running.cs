public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int length, double distance) : base("Running", date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60; // miles per hour
    }

    public override double GetPace()
    {
        return _length / _distance; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
