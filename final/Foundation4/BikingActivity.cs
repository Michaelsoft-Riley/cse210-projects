public class BikingActivity : Activity
{
    private double _speed;

    public BikingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        _activityName = "Biking";
    }

    public override double GetDistance()
    {
        return _speed / 60 * _minutes;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}