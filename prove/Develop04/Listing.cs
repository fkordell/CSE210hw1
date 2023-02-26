using System;

public class Listing : Activity{

    Activity activity = new Activity();
    public Listing(){

        _startMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityType = "Listing Activity";
        _finishMessage = "Well Done!";
    
    }

    public override void doActivity()
    {
        GetStartMessage();
        GetReady();

        Console.WriteLine("Think about this question for a few seconds");
        Console.WriteLine();
        string prompt = activity.GetRandPropmt3();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Thread.Sleep(4000);

        float seconds = Convert.ToInt32(_duration);
        Console.WriteLine("Start listing as many things as possible until the timer runs out: ");
        Console.WriteLine();
            for (int i = 0; i < Math.Ceiling(seconds/8); i++){
                string response = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("You have completed tasks!");

        GetEndMessage();
    }


}