using System;

public class products{

public int _idNum;
public string _productName;
public double _price;

public double _quantity;

public double GetTotal(){

    return _quantity * _price;
}

}