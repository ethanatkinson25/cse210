using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        Random random = new Random();

        string[] addresses = {
            "123 Main St",
            "456 Oak Avenue",
            "789 Pine Road",
            "101 Maple Blvd",
            "221B Baker Street",
            "1600 Pennsylvania Ave NW",
            "5 Chome-1-1 Tsukiji",
            "1 Harbourfront Walk"
        };

        string[] cities = {
            "Salt Lake City",
            "Denver",
            "Seattle",
            "Austin",
            "London",
            "Washington",
            "Tokyo",
            "Singapore"
        };

        string[] states = {
            "UT",
            "CO",
            "WA",
            "TX",
            "Tokyo Metropolis",
            "Okinawa Prefecture",
            "DC",
            "England",
            "Wales",
            "Singapore"
        };

        string[] countries = {
            "USA",
            "UK",
            "USA",
            "Japan",
            "Singapore"
        };

        _streetAddress = addresses[random.Next(addresses.Length)];
        _city = cities[random.Next(cities.Length)];
        _state = states[random.Next(states.Length)];
        _country = countries[random.Next(countries.Length)];
    }

    public string getFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public bool isInUSA()
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

}