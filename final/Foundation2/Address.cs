public class Address
{
    private string _street;
    private string _city;
    // state or province
    private string _stateProvince;
    private string _country;

    public Address(string address)
    {
        string[] addressDetails = address.Split(',');

        _street = addressDetails[0];
        _city = addressDetails[1];
        _stateProvince = addressDetails[2];
        _country = addressDetails[3];
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