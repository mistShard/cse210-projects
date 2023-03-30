using System;

public class Customer 
{
    private string _name;
    private Address _address;

    public void SetCustomerDetails(string name, Address address) {
        _name = name;
        _address = address;
    }

    public string GetCustomerName() {
        return _name;
    }

    public string GetCustomerAddress() {
        return _address.GetAddress();
    }

    public bool LivesLocal() {
        return _address.IsLocal();
    }
}