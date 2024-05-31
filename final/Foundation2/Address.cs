public class Address
{
    private string _street;
    private string _city;
    // state or province
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_stateProvince}, {_country}";
    }
}