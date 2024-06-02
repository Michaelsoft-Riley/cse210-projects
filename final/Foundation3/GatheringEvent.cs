public class GatheringEvent: Event
{
    private string _weather;

    public GatheringEvent(string title, string description, string date, string time, string address,
    string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        _type = "Gathering";
    }

    public override string GetFullDetails()
    {
        string typeString = $"Type: {_type}";
        string baseDetails = GetBaseDetails();
        return $"{typeString}\n{baseDetails}\nWeather: {_weather}";
    }
}