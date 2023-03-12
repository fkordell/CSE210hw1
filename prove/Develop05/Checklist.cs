using System;

public class Checklist : Goals{

    protected int _timesCompleted;
    protected int _timesForCompleted;

    public Checklist(){

    }

    public void GetInput(){

        Console.WriteLine("What is the name of this goal? ");
        Console.WriteLine();
        _goalName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Please put in a short description for this goal: ");
        Console.WriteLine();
        _goalDescription = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("How many points do you want to assign to this goal? ");
        Console.WriteLine();
        _pointValue = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("How many times do you want to do this goal?");
        Console.WriteLine();
        _timesForCompleted = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();
    }
      public override void fromFileLine(string fileline) {
    
    string [] parts = fileline.Split(",");
     _goalName = parts[1];
     _goalDescription = parts[2];
     _pointValue = Convert.ToInt16(parts[3]);
 
    }

    public override string toFileLine() {
        return "C" + "," + _goalName + "," + _goalDescription + "," +_pointValue;
    }
}