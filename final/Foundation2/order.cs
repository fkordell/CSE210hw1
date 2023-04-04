using System;

public class Order{

    private List<Products> _products; 
    private Customer _customer;

    public Order(){
        _products = new List<Products>();
    }

    public double GetTotalPrice(){
        double total = 0;
        foreach(Products product in _products){
            total += product.GetItemTotal();
        }
        return total;
    }
    public void GetOrderTotal(){
        Console.WriteLine($"Order total: {Math.Round(GetTotalPrice(), 2) + GetShippingAmount()}");
    }
    public void DisplayPackingLabel(){
        Console.WriteLine("Packing Label:");
        foreach(Products product in _products){
            Console.WriteLine($"{product.GetName()}, ID#{product.GetID()}");
        }
    }
    public void DisplayShippingLabel(){
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{_customer.GetName()}, {_customer.DisplayAddress()}");
    }

    public int GetShippingAmount(){
        if(_customer.isUSA() == true){
            return 5;
        }
        else{
            return 35;
        }
    }
    public void AddItem(string _productName, int _idNum, double _price, int _quantity){
        _products.Add(new Products(_productName, _idNum, _price, _quantity));
    }
    public void SetCustName(string custName){
        _customer = new Customer(custName);
    }
    public void SetCustAddress(string streetAddress, string city, string stateProv, string country){
        _customer.SetAddress(streetAddress, city, stateProv, country);
    }
    
}