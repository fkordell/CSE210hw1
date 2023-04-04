using System;

public class Products{

private int _idNum;
private string _productName;
private double _price;

private int _quantity;


public Products(string productName, int idNum, double price, int quantity){

    _productName = productName;
    _idNum = idNum;
    _price = price;
    _quantity = quantity;
}

public double GetItemTotal(){

    return _quantity * _price;
}
public string GetName(){
    return _productName;
}
public int GetID(){
    return _idNum;
}
public int GetQauntity(){
    return _quantity;
}
public double GetItemPrice(){
    return _price;
}
}
