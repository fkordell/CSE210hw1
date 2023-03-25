using System;

public class Running : Activity{

    private double _laps;
    Activity activity = new Activity();
    public Running(){

        DateTime localDate = DateTime.Now;
        string _currentDate = localDate.ToString("dd/MM/yyyy");

        
    }

    public override void doActivity()
    {
        Console.WriteLine("How many laps did you run today?");
        _laps = Convert.ToInt16(Console.ReadLine());
        _distance = _laps * 4;
        Console.WriteLine($"You ran {_distance} miles today");
        Console.WriteLine("How long did you run for today in minutes?");
        _activityLength = Convert.ToInt16(Console.ReadLine());
        
    }
}