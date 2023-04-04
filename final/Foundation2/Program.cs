using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Order order2 = new Order();
        order1.SetCustName("Bill Ross");
        order1.SetCustAddress("134 14th St.", "Rexburg", "Idaho", "USA");
        order1.AddItem("Pants", 1234, 24.95, 1);
        order1.AddItem("Shoes", 2345, 75, 1 );
        order1.AddItem("Shirts", 3456, 35.65, 2);
        Console.WriteLine();
        Console.WriteLine("Order 1");
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayShippingLabel();
        order1.GetOrderTotal();
        Console.WriteLine();
        Console.WriteLine();
        order2.SetCustName("Jane Moser");
        order2.SetCustAddress("25 N. Main St.", "Cape Town", "Western Cape", "SA");
        order2.AddItem("Soccer Boots", 465363, 145.55, 1);
        order2.AddItem("Shin Gaurds", 223354, 45.55, 1);
        order2.AddItem("football socks", 58674, 51.99, 2);
        Console.WriteLine();
        Console.WriteLine("Order 2");
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayShippingLabel();
        order2.GetOrderTotal();

    }
}