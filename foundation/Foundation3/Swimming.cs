public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // kph
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); // min per km
    }
}