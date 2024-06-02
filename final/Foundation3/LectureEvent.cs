public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, string address,
    string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _type = "Lecture";
    }

    public override string GetFullDetails()
    {
        string typeString = $"Type: {_type}";
        string baseDetails = GetBaseDetails();
        return $"{typeString}\n{baseDetails}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}