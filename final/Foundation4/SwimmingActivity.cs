public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _activityName = "Swimming";
    }

    public override double GetDistance()
    {
        return (double)_laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}