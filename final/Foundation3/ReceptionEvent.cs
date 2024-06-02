public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, string address,
    string email) : base(title, description, date, time, address)
    {
        _email = email;
        _type = "Reception";
    }

    public override string GetFullDetails()
    {
        string typeString = $"Type: {_type}";
        string baseDetails = GetBaseDetails();
        return $"{typeString}\n{baseDetails}\nEmail: {_email}";
    }
}