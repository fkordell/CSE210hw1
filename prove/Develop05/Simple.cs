using System;

public class Simple : Goals{

    protected bool _isComplete;


    public Simple(){

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
        _isComplete = false;
        Console.WriteLine();
    }

    public override void fromFileLine(string fileline) {
    
    string [] parts = fileline.Split(",");
     _goalName = parts[1];
     _goalDescription = parts[2];
     _pointValue = Convert.ToInt16(parts[3]);
 
    }

    public override string toFileLine() {
        return "S" + "," + _goalName + "," + _goalDescription + "," +_pointValue;
    }

    public override void doGoal()
    {
    }

}