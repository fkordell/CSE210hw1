using System; 

public class Address{

    private string streetAddress;
    private string city;
    private string state;
    private string zipCode;


    public Address(string _streetAdress, string _city, string _state, string _zipCode){

        streetAddress = _streetAdress;
        city = _city;
        state = _state;
        zipCode = _zipCode;
    }
}