public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string addressString)
    {
        _name = name;
        _address = new(addressString);
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _address.GetAddressString();
    }
}