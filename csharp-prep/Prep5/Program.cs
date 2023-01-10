using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        WelcomeMessage();

        string yourname = GetName();
        int yournumber = GetNumber();
        int NumberSquared = GetNumberSquared(yournumber);
        
        outcome(yourname, NumberSquared);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome");
    }
    static string GetName()
    {
        Console.Write("Write your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetNumber()
    {
        Console.Write("Input your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int GetNumberSquared(int num)
    {
        int squarenum = num * num;
        return squarenum;
    } 

    static void outcome(string yourname, int squarenum)
    {
        Console.WriteLine($"{yourname}, your number squared is {squarenum}");
    }   
}