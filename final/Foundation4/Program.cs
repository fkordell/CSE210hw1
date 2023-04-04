using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(30);
        Cycling cycling = new Cycling(40);
        Swimming swimming = new Swimming(20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine();
        Console.WriteLine("Welcome to the Exercise Tracking program!");
        Console.WriteLine("Your fitness activities for today are:");
        Console.WriteLine();
        foreach(Activity activity in activities){
            activity.getSummary(30);
        }
        Console.WriteLine(running.getSummary(3.0));
        Console.WriteLine(cycling.getSummary(3.0));
        Console.WriteLine(swimming.getSummary(6.0));
        Console.WriteLine();

        }

     
}