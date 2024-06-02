public abstract class Activity
{
    private string _date;
    protected double _minutes;
    protected string _activityName;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    // This currently has different behavior for each activity.
    // This may change as more activities are added.

    public virtual double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    public string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 3);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);
        return $"{_date} {_activityName} ({_minutes}) - " +
        $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}