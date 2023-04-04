using System;

public class Address{
    private string _streetAddress;

    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string streetAddress, string city, string stateProv, string country){
        _streetAddress = streetAddress;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }

    public bool isUSA(){
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }

    }

    public string DisplayAddress(){
        return $"Address: {_streetAddress}, {_city}, {_stateProv}, {_country}";
    }
}