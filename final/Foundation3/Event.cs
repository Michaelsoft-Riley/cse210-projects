public abstract class Event
{
    protected string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new(address);
    }

    public string GetShortDetails()
    // returns event type, title, and date as a single string
    {
        return $"{_type} - {_title} - {_date}";
    }

    public string GetBaseDetails()
    // returns title, description, date, time, and address as a single string
    {
        string addressString = _address.GetAddressString();
        return $"{_title} - {_description}\n{_date} @ {_time}\n{addressString}";
    }

    public abstract string GetFullDetails();
    // returns base details + child class unique attributes
}