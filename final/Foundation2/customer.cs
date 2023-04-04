using System;

public class Customer{

    private string _custName;

    private Address _customerAddress;
    public Customer(string custName){
        _custName = custName;
    }
    public void SetAddress(string streetAddress, string city, string stateProv, string country){
        _customerAddress = new Address(streetAddress, city, stateProv, country);
    }
    public bool isUSA(){
        return _customerAddress.isUSA();
    }
    public string GetName(){
        return _custName;
    }
    public string DisplayAddress(){
        return _customerAddress.DisplayAddress();
    }
}