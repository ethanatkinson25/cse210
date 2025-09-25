using System;

public class Customer
{
    private string _customerName;
    private Address _address = new Address();

    public Customer()
    {
        Random random = new Random();

        string[] names = { "Bob", "Jake", "Jessica", "Mark", "Susan", "Ethan", "Levi", "Anna", "Josh", "Lilly" };
        // string address = _address.getFullAddress();
        _customerName = names[random.Next(names.Length)];
    }

    public bool getUSAStatus()
    {
        return _address.isInUSA();
    }

    public string getCustomerInfo()
    {
        return $"{_customerName},\n {_address.getFullAddress()}";
    }
}