public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int minutes, double speed) 
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60; // distance in km
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        return 60 / _speed; // min per km
    }
}
