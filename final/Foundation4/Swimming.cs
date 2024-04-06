public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base("Swimming", date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // kilometers
    }

    public override double GetSpeed()
    {
        return (_laps * 50 / 1000) / _length * 60; // kilometers per hour
    }

    public override double GetPace()
    {
        return _length / (_laps * 50 / 1000); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}